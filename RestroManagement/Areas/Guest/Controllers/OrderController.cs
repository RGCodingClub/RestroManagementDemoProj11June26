using Microsoft.AspNetCore.Authorization; 
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RestroManagement.Data;
using RestroManagement.DbModels;
using RestroManagement.ViewModels; 
using System.Text.Json; 

namespace RestroManagement.Areas.Guest.Controllers
{
    [Area("Guest")]
    //[Authorize(Roles = "Guest")]
    public class OrderController : Controller
    {
        private readonly AppDBContext _context;

        public OrderController(AppDBContext context)
        {
            _context = context;
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
            var order = new Order
            {
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
