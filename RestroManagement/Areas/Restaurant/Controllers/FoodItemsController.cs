using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RestroManagement.Data;
using RestroManagement.DbModels;

namespace RestroManagement.Areas.Restaurant.Controllers
{
    [Area("Restaurant")]
    //[Authorize(Roles = "Restaurant")]

    public class FoodItemsController : Controller
    {
        private readonly AppDBContext _context;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public FoodItemsController(AppDBContext context, IWebHostEnvironment webHostEnvironment)
        {
            _context = context;
            _webHostEnvironment = webHostEnvironment;
        }

        public async Task<IActionResult> Index()
        {
            var items = await _context.Fooditems
                .Include(f => f.Portions)
                .Include(f => f.Images)
                .Include(f => f.Categories)
                    .ThenInclude(fc => fc.Category)
                .OrderByDescending(f => f.Created)
                .ToListAsync();
            return View(items);
        }

        public async Task<IActionResult> Create()
        {
            ViewBag.Categories = await _context.MenuCategories.OrderBy(c => c.DisplayOrder).ToListAsync();
            return View(new FoodItem());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(FoodItem item, int[] selectedCategories, List<IFormFile>? imageFiles, List<string>? externalUrls, int primaryImageIndex)
        {
            item.Created = DateTime.Now;
            item.LastUpdated = DateTime.Now;

            if (ModelState.IsValid)
            {
                item.Images = new List<FoodItemImage>();
                int currentIndex = 0;

                // Handle External URLs
                if (externalUrls != null)
                {
                    foreach (var url in externalUrls.Where(u => !string.IsNullOrEmpty(u)))
                    {
                        item.Images.Add(new FoodItemImage
                        {
                            ImageUrl = url,
                            IsPrimary = (currentIndex == primaryImageIndex)
                        });
                        currentIndex++;
                    }
                }

                // Handle File Uploads
                if (imageFiles != null)
                {
                    foreach (var file in imageFiles)
                    {
                        var path = await SaveImage(file);
                        item.Images.Add(new FoodItemImage
                        {
                            ImageUrl = path,
                            IsPrimary = (currentIndex == primaryImageIndex)
                        });
                        currentIndex++;
                    }
                }

                // Ensure at least one primary if images exist
                if (item.Images.Any() && !item.Images.Any(i => i.IsPrimary))
                {
                    item.Images.First().IsPrimary = true;
                }

                _context.Add(item);
                await _context.SaveChangesAsync();

                if (selectedCategories != null)
                {
                    foreach (var categoryId in selectedCategories)
                    {
                        _context.FoodItemCategories.Add(new FoodItemCategory { FoodItemId = item.Id, CategoryId = categoryId });
                    }
                    await _context.SaveChangesAsync();
                }

                return RedirectToAction(nameof(Edit), new { id = item.Id });
            }

            ViewBag.Categories = await _context.MenuCategories.OrderBy(c => c.DisplayOrder).ToListAsync();
            return View(item);
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null) return NotFound();

            var item = await _context.Fooditems
                .Include(f => f.Portions)
                .Include(f => f.Images)
                .Include(f => f.Categories)
                .FirstOrDefaultAsync(f => f.Id == id);

            if (item == null) return NotFound();

            ViewBag.Categories = await _context.MenuCategories.OrderBy(c => c.DisplayOrder).ToListAsync();
            return View(item);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, FoodItem item, int[] selectedCategories, List<IFormFile>? imageFiles, List<string>? externalUrls, int primaryImageIndex)
        {
            if (id != item.Id) return NotFound();

            if (ModelState.IsValid)
            {
                var existingItem = await _context.Fooditems
                    .Include(f => f.Categories)
                    .Include(f => f.Images)
                    .FirstOrDefaultAsync(f => f.Id == id);

                if (existingItem == null) return NotFound();

                existingItem.Name = item.Name;
                existingItem.Description = item.Description;
                existingItem.DietaryPreference = item.DietaryPreference;
                existingItem.PriceCalculationMethod = item.PriceCalculationMethod;
                existingItem.IsAvailable = item.IsAvailable;
                existingItem.LastUpdated = DateTime.Now;

                // Handle Image Updates - Simple approach: Add new ones
                // To support "primary" change on existing, we'd need more complex logic.
                // For now, let's just add new ones as requested.

                if (externalUrls != null || imageFiles != null)
                {
                    // If a new primary is set from the new batch, reset existing primaries
                    bool newPrimaryInBatch = primaryImageIndex >= (existingItem.Images?.Count ?? 0);
                    if (newPrimaryInBatch && existingItem.Images != null)
                    {
                        foreach (var img in existingItem.Images) img.IsPrimary = false;
                    }

                    int currentIndex = existingItem.Images?.Count ?? 0;

                    if (externalUrls != null)
                    {
                        foreach (var url in externalUrls.Where(u => !string.IsNullOrEmpty(u)))
                        {
                            existingItem.Images?.Add(new FoodItemImage { ImageUrl = url, IsPrimary = (currentIndex == primaryImageIndex) });
                            currentIndex++;
                        }
                    }

                    if (imageFiles != null)
                    {
                        foreach (var file in imageFiles)
                        {
                            var path = await SaveImage(file);
                            existingItem.Images?.Add(new FoodItemImage { ImageUrl = path, IsPrimary = (currentIndex == primaryImageIndex) });
                            currentIndex++;
                        }
                    }
                }

                // Update Categories
                _context.FoodItemCategories.RemoveRange(existingItem.Categories!);
                if (selectedCategories != null)
                {
                    foreach (var categoryId in selectedCategories)
                    {
                        _context.FoodItemCategories.Add(new FoodItemCategory { FoodItemId = id, CategoryId = categoryId });
                    }
                }

                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            ViewBag.Categories = await _context.MenuCategories.OrderBy(c => c.DisplayOrder).ToListAsync();
            return View(item);
        }

        [HttpPost]
        public async Task<IActionResult> SetPrimaryImage(int foodItemId, int imageId)
        {
            var images = await _context.FoodItemImages.Where(i => i.FoodItemId == foodItemId).ToListAsync();
            foreach (var img in images)
            {
                img.IsPrimary = (img.Id == imageId);
            }
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Edit), new { id = foodItemId });
        }

        [HttpPost]
        public async Task<IActionResult> DeleteImage(int id)
        {
            var image = await _context.FoodItemImages.FindAsync(id);
            if (image != null)
            {
                int foodItemId = image.FoodItemId;
                _context.FoodItemImages.Remove(image);
                await _context.SaveChangesAsync();

                // Ensure at least one primary remains
                var remainingImages = await _context.FoodItemImages.Where(i => i.FoodItemId == foodItemId).ToListAsync();
                if (remainingImages.Any() && !remainingImages.Any(i => i.IsPrimary))
                {
                    remainingImages.First().IsPrimary = true;
                    await _context.SaveChangesAsync();
                }

                return RedirectToAction(nameof(Edit), new { id = foodItemId });
            }
            return NotFound();
        }

        private async Task<string> SaveImage(IFormFile file)
        {
            string wwwRootPath = _webHostEnvironment.WebRootPath;
            string fileName = Guid.NewGuid().ToString() + Path.GetExtension(file.FileName);
            string path = Path.Combine(wwwRootPath, @"images\food", fileName);

            using (var fileStream = new FileStream(path, FileMode.Create))
            {
                await file.CopyToAsync(fileStream);
            }

            return @"/images/food/" + fileName;
        }

        [HttpPost]
        public async Task<IActionResult> AddPortion(FoodItemPortion portion)
        {
            if (ModelState.IsValid)
            {
                _context.FoodItemPortions.Add(portion);
                await _context.SaveChangesAsync();
            }
            return RedirectToAction(nameof(Edit), new { id = portion.FoodItemId });
        }


        public async Task<IActionResult> DeletePortion(int id)
        {
            var portion = await _context.FoodItemPortions.FindAsync(id);
            if (portion != null)
            {
                int foodItemId = portion.FoodItemId;
                _context.FoodItemPortions.Remove(portion);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Edit), new { id = foodItemId });
            }
            return NotFound();
        }

        public async Task<IActionResult> Delete(int id)
        {
            var item = await _context.Fooditems.FindAsync(id);
            if (item != null)
            {
                _context.Fooditems.Remove(item);
                await _context.SaveChangesAsync();
            }
            return RedirectToAction(nameof(Index));
        }
    }
}
