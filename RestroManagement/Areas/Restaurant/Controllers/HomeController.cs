using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RestroManagement.Data;

namespace RestroManagement.Areas.Restaurant.Controllers
{
    [Area("Restaurant")]
    //[Authorize(Roles = "Restaurant")]

    public class HomeController : Controller
    {
        private readonly AppDBContext _context;

        public HomeController(AppDBContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            ViewBag.FoodItemCount = await _context.Fooditems.CountAsync();
            ViewBag.CategoryCount = await _context.MenuCategories.CountAsync();
            ViewBag.OrderCount = await _context.Orders.CountAsync();
            ViewBag.TotalRevenue = await _context.OrderItems.SumAsync(oi => oi.Price);

            var recentOrders = await _context.Orders
                .Include(o => o.Items)
                  .ThenInclude(oi => oi.FoodItem)
                .OrderByDescending(o => o.OrderDate)
                .Take(5)
                .ToListAsync();

            return View(recentOrders);
        }
    }
}
