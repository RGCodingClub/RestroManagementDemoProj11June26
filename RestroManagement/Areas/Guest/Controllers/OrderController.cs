using Microsoft.AspNetCore.Authorization; 
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RestroManagement.Data;
using Microsoft.AspNetCore.Identity;
using RestroManagement.DbModels;
using RestroManagement.DbModels.User;
using RestroManagement.ViewModels; 
using System.Text.Json; 

namespace RestroManagement.Areas.Guest.Controllers
{
    [Area("Guest")]
    //[Authorize(Roles = "Guest")]
    public class OrderController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly AppDBContext _context;
        public OrderController(AppDBContext context,
                       UserManager<AppUser> userManager)
        
        {
            _context = context;
            _userManager = userManager;

        }
        public async Task<IActionResult> MyOrders()
        {
            var user = await _userManager.GetUserAsync(User);

            if (user == null)
            {
                return RedirectToAction("Login", "Account");
            }

            var orders = await _context.Orders
               .Include(o => o.Items)
                  .ThenInclude(i => i.FoodItem)
               .Include(o => o.Items)
                  .ThenInclude(i => i.Portion)
               .Where(o => o.UserId == user.Id.ToString()).OrderByDescending(o => o.OrderDate).ToListAsync();
           

            return View(orders);
        }
        public async Task<IActionResult> OrderDetails(int id)
        {
            var user = await _userManager.GetUserAsync(User);

            if (user == null)
            {
                return RedirectToAction("Login", "Account");
            }
            var order = await _context.Orders
                .Include(o => o.Items)
                    .ThenInclude(i => i.FoodItem)
                .Include(o => o.Items)
                    .ThenInclude(i => i.Portion)
                .FirstOrDefaultAsync(o => o.Id == id && o.UserId == user.Id.ToString());
            if (order == null)
            {
                return NotFound();
            }

            return View(order);
        }
        // GET: Guest/Order/Checkout
        public IActionResult Checkout()
        {
            var cartJson = HttpContext.Session.GetString("Cart");
            var cart = string.IsNullOrEmpty(cartJson)
                ? new List<CartItem>()
                : JsonSerializer.Deserialize<List<CartItem>>(cartJson) ?? new List<CartItem>();

            if (!cart.Any())
            {
                return RedirectToAction("Menu", "Home");
            }

            return View(cart);
        }

        // POST: Guest/Order/Checkout
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Checkout(string CustomerName, string MobileNumber)
        {
            var cartJson = HttpContext.Session.GetString("Cart");
            var cart = string.IsNullOrEmpty(cartJson)
                ? new List<CartItem>()
                : JsonSerializer.Deserialize<List<CartItem>>(cartJson) ?? new List<CartItem>();

            if (!cart.Any())
            {
                ModelState.AddModelError("", "Your cart is empty.");
                return RedirectToAction("Menu", "Home");
            }

            if (string.IsNullOrWhiteSpace(CustomerName))
            {
                ModelState.AddModelError("CustomerName", "Customer name is required.");
            }
            if (string.IsNullOrWhiteSpace(MobileNumber))
            {
                ModelState.AddModelError("MobileNumber", "Mobile number is required.");
            }

            if (!ModelState.IsValid)
            {
                return View(cart);
            }

            // Create Order
            var user = await _userManager.GetUserAsync(User);
            
            int? merchantId = null;
            int? storeId = null;
            if (cart.Any())
            {
                var firstItemId = cart[0].FoodItemId;
                var foodItem = await _context.Fooditems.FindAsync(firstItemId);
                if (foodItem != null)
                {
                    merchantId = foodItem.MerchantId;
                    if (merchantId.HasValue)
                    {
                        var store = await _context.Stores.FirstOrDefaultAsync(s => s.MerchantId == merchantId.Value);
                        if (store != null)
                        {
                            storeId = store.UniqueId;
                        }
                    }
                }
            }

            var order = new Order
            {
                UserId = user.Id.ToString(),
                MerchantId = merchantId,
                StoreId = storeId,
                CustomerName = CustomerName,
                MobileNumber = MobileNumber,
                OrderDate = DateTime.Now,
                PackagingCharges = 30,
                Discount = 0,
                Items = new List<OrderItem>()
            };

            // Loop through cart items and add them
            foreach (var item in cart)
            {
                // Find matching portion if it exists in DB
                var portion = await _context.FoodItemPortions
                    .FirstOrDefaultAsync(p => p.FoodItemId == item.FoodItemId && p.Name == item.PortionName);

                order.Items.Add(new OrderItem
                {
                    FoodItemId = item.FoodItemId,
                    FoodItemPortionId = portion?.Id,
                    Quantity = item.Quantity,
                    Price = (float)item.Price
                });
            }

            _context.Orders.Add(order);
            await _context.SaveChangesAsync();

            // Clear the session cart
            HttpContext.Session.Remove("Cart");

            TempData["OrderId"] = order.Id;
            return RedirectToAction(nameof(OrderSuccess));
        }

        // GET: Guest/Order/OrderSuccess
        public async Task<IActionResult> OrderSuccess()
        {
            if (TempData["OrderId"] is int orderId)
            {
                var order = await _context.Orders
                    .Include(o => o.Items)
                        .ThenInclude(oi => oi.FoodItem)
                    .Include(o => o.Items)
                        .ThenInclude(oi => oi.Portion)
                    .FirstOrDefaultAsync(o => o.Id == orderId);

                if (order != null)
                {
                    return View(order);
                }
            }

            return RedirectToAction("Menu", "Home");
        }
    }
}
