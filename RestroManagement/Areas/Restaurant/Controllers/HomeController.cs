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
        public async Task<IActionResult> RecentOrders(DateTime date)
        {
            var orders = await _context.Orders
                .Include(o => o.Items)
                .ThenInclude(i => i.FoodItem)
                .Where(o => o.OrderDate.Date == date.Date)
                .OrderByDescending(o => o.OrderDate)
                .ToListAsync();
            return PartialView("~/Areas/Restaurant/Views/Home/RecentOrders.cshtml", orders);
        }
        public async Task<IActionResult> GetRecentOrders(DateTime date)
        {
            var orders = await _context.Orders
                .Include(o => o.Items)
                .ThenInclude(i => i.FoodItem)
                .Where(o => o.OrderDate.Date == date.Date)
                .OrderByDescending(o => o.OrderDate)
                .ToListAsync();
            return PartialView("~/Areas/Restaurant/Views/Home/RecentOrders.cshtml", orders);
        }
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null) return NotFound();

            var order = await _context.Orders
                .Include(o => o.Items)
                    .ThenInclude(oi => oi.FoodItem)
                .Include(o => o.Items)
                    .ThenInclude(oi => oi.Portion)
                .FirstOrDefaultAsync(m => m.Id == id);

            if (order == null) return NotFound();

            return View(order);
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
        // GET: Guest/Home/Customers
        public async Task<IActionResult> Customers()
        {
            // Get all users from the database (AppUser)
            var users = await _context.Users.ToListAsync();
            return View(users);
        }



    }
}
