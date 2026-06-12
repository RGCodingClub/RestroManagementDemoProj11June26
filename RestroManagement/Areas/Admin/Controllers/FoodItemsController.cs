using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RestroManagement.Data;
using RestroManagement.DbModels;

namespace RestroManagement.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class FoodItemsController : Controller
    {
        private readonly AppDBContext _context;

        public FoodItemsController(AppDBContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var items = await _context.Fooditems
                .Include(f => f.Portions)
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
        public async Task<IActionResult> Create(FoodItem item, int[] selectedCategories)
        {
            item.Created = DateTime.Now;
            item.LastUpdated = DateTime.Now;

            if (ModelState.IsValid)
            {
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
                .Include(f => f.Categories)
                .FirstOrDefaultAsync(f => f.Id == id);

            if (item == null) return NotFound();

            ViewBag.Categories = await _context.MenuCategories.OrderBy(c => c.DisplayOrder).ToListAsync();
            return View(item);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, FoodItem item, int[] selectedCategories)
        {
            if (id != item.Id) return NotFound();

            if (ModelState.IsValid)
            {
                var existingItem = await _context.Fooditems.Include(f => f.Categories).FirstOrDefaultAsync(f => f.Id == id);
                if (existingItem == null) return NotFound();

                existingItem.Name = item.Name;
                existingItem.Description = item.Description;
                existingItem.ImageUrl = item.ImageUrl;
                existingItem.DietaryPreference = item.DietaryPreference;
                existingItem.PriceCalculationMethod = item.PriceCalculationMethod;
                existingItem.IsAvailable = item.IsAvailable;
                existingItem.LastUpdated = DateTime.Now;

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
        public async Task<IActionResult> AddPortion(FoodItemPortion portion)
        {
            if (ModelState.IsValid)
            {
                _context.FoodItemPortions.Add(portion);
                await _context.SaveChangesAsync();
            }
            return RedirectToAction(nameof(Edit), new { id = portion.FoodItemId });
        }

        [HttpPost]
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
