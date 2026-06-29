using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RestroManagement.Data;

namespace RestroManagement.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]

    public class DashboardController : Controller
    {
        private readonly AppDBContext _context;

        public DashboardController(AppDBContext context)
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
                .OrderByDescending(o => o.OrderDate)
                .Take(5)
                .ToListAsync();

            return View(recentOrders);
        }
    }
}
