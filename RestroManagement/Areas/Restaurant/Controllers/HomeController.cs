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
        private readonly RestroManagement.Services.IAccountService _accountService;

        public HomeController(AppDBContext context, RestroManagement.Services.IAccountService accountService)
        {
            _context = context;
            _accountService = accountService;
        }
        public async Task<IActionResult> RecentOrders(DateTime date)
        {
            var merchantId = _accountService.GetLoggedInUserMerchantId() ?? 0;
            var orders = await _context.Orders
                .Include(o => o.Items)
                .ThenInclude(i => i.FoodItem)
                .Where(o => o.OrderDate.Date == date.Date && o.MerchantId == merchantId)
                .OrderByDescending(o => o.OrderDate)
                .ToListAsync();
            return PartialView("~/Areas/Restaurant/Views/Home/RecentOrders.cshtml", orders);
        }
        public async Task<IActionResult> GetRecentOrders(DateTime date)
        {
            var merchantId = _accountService.GetLoggedInUserMerchantId() ?? 0;
            var orders = await _context.Orders
                .Include(o => o.Items)
                .ThenInclude(i => i.FoodItem)
                .Where(o => o.OrderDate.Date == date.Date && o.MerchantId == merchantId)
                .OrderByDescending(o => o.OrderDate)
                .ToListAsync();
            return PartialView("~/Areas/Restaurant/Views/Home/RecentOrders.cshtml", orders);
        }
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null) return NotFound();

            var merchantId = _accountService.GetLoggedInUserMerchantId() ?? 0;
            var order = await _context.Orders
                .Include(o => o.Items)
                    .ThenInclude(oi => oi.FoodItem)
                .Include(o => o.Items)
                    .ThenInclude(oi => oi.Portion)
                .FirstOrDefaultAsync(m => m.Id == id && m.MerchantId == merchantId);

            if (order == null) return NotFound();

            return View(order);
        }
        public async Task<IActionResult> Index()
        {
            var merchantId = _accountService.GetLoggedInUserMerchantId() ?? 0;
            ViewBag.FoodItemCount = await _context.Fooditems.CountAsync(f => f.MerchantId == merchantId);
            ViewBag.CategoryCount = await _context.MenuCategories.CountAsync();
            ViewBag.OrderCount = await _context.Orders.CountAsync(o => o.MerchantId == merchantId);
            ViewBag.TotalRevenue = await _context.OrderItems
                .Include(oi => oi.Order)
                .Where(oi => oi.Order!.MerchantId == merchantId)
                .SumAsync(oi => oi.Price);

            var recentOrders = await _context.Orders
                .Include(o => o.Items)
                  .ThenInclude(oi => oi.FoodItem)
                .Where(o => o.MerchantId == merchantId)
                .OrderByDescending(o => o.OrderDate)
                .Take(5)
                .ToListAsync();

            return View(recentOrders);
        }
        // GET: Guest/Home/Customers
        public async Task<IActionResult> Customers()
        {
            var merchantId = _accountService.GetLoggedInUserMerchantId() ?? 0;
            var userIds = await _context.Orders
                .Where(o => o.MerchantId == merchantId)
                .Select(o => o.UserId)
                .Distinct()
                .ToListAsync();

            var users = await _context.Users
                .Where(u => userIds.Contains(u.Id.ToString()))
                .ToListAsync();
            return View(users);
        }



    }
}
