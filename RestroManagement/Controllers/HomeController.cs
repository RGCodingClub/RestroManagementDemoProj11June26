using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RestroManagement.Data;
using RestroManagement.Models;
using RestroManagement.DbModels;
using System.Diagnostics;

namespace RestroManagement.Controllers
{

    public class HomeController(AppDBContext appDBContext) : Controller
    {
        private readonly AppDBContext _context = appDBContext;

        public IActionResult Index()
        {
            return View();
        }
        public async Task<IActionResult> RestaurantLandingPage()
        {
            var merchant = await _context.Merchants.FirstOrDefaultAsync(m => m.UniqueId == 1) 
                           ?? await _context.Merchants.FirstOrDefaultAsync();
            
            if (merchant == null)
            {
                DbInitializer.Initialize(_context);
                merchant = await _context.Merchants.FirstOrDefaultAsync();
            }

            var store = await _context.Stores.FirstOrDefaultAsync(s => s.MerchantId == merchant!.UniqueId);

            ViewBag.Merchant = merchant;
            ViewBag.Store = store;

            var merchantId = merchant?.UniqueId ?? 1;

            var items = await _context.Fooditems
              .Include(f => f.Portions)
              .Include(f => f.Images)
              .Include(f => f.Categories)
                  .ThenInclude(fc => fc.Category)
              .OrderByDescending(f => f.Created)
              .Where(f => f.MerchantId == merchantId)
              .ToListAsync();
            return View(items);
        }

        public class OrderSubmissionModel
        {
            public string CustomerName { get; set; } = string.Empty;
            public string MobileNumber { get; set; } = string.Empty;
            public string? TableNumber { get; set; }
            public string? DeliveryAddress { get; set; }
            public string OrderType { get; set; } = "DineIn";
            public List<OrderSubmissionItemModel> Items { get; set; } = new List<OrderSubmissionItemModel>();
        }

        public class OrderSubmissionItemModel
        {
            public int FoodItemId { get; set; }
            public string PortionName { get; set; } = string.Empty;
            public float Price { get; set; }
            public int Quantity { get; set; }
        }

        [HttpPost]
        public async Task<IActionResult> PlaceLandingOrder([FromBody] OrderSubmissionModel model)
        {
            if (model == null || string.IsNullOrWhiteSpace(model.CustomerName) || string.IsNullOrWhiteSpace(model.MobileNumber) || model.Items == null || !model.Items.Any())
            {
                return Json(new { success = false, message = "Invalid order details. Please check all fields." });
            }

            var merchant = await _context.Merchants.FirstOrDefaultAsync(m => m.UniqueId == 1) 
                           ?? await _context.Merchants.FirstOrDefaultAsync();
            var store = await _context.Stores.FirstOrDefaultAsync(s => s.MerchantId == merchant!.UniqueId);

            var order = new Order
            {
                UserId = _context.Users.FirstOrDefault()?.Id.ToString() ?? "1",
                MerchantId = merchant?.UniqueId ?? 1,
                StoreId = store?.UniqueId,
                CustomerName = model.CustomerName,
                MobileNumber = model.MobileNumber,
                OrderDate = DateTime.Now,
                PackagingCharges = model.OrderType == "Delivery" ? 40 : 20,
                Discount = 0,
                Items = new List<OrderItem>()
            };

            foreach (var item in model.Items)
            {
                var portion = await _context.FoodItemPortions
                    .FirstOrDefaultAsync(p => p.FoodItemId == item.FoodItemId && p.Name == item.PortionName);

                order.Items.Add(new OrderItem
                {
                    FoodItemId = item.FoodItemId,
                    FoodItemPortionId = portion?.Id,
                    Quantity = item.Quantity,
                    Price = item.Price
                });
            }

            _context.Orders.Add(order);
            await _context.SaveChangesAsync();

            return Json(new { success = true, orderId = order.Id });
        }

        public IActionResult CommercialIndex()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
