using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RestroManagement.Data;

namespace RestroManagement.Areas.Restaurant.Controllers
{
    [Area("Restaurant")]
    //[Authorize(Roles = "Restaurant")]

    public class OrdersController : Controller
    {
        private readonly AppDBContext _context;
        private readonly RestroManagement.Services.IAccountService _accountService;

        public OrdersController(AppDBContext context, RestroManagement.Services.IAccountService accountService)
        {
            _context = context;
            _accountService = accountService;
        }
        
        public async Task<IActionResult> Index(DateTime? fromDate, DateTime? toDate)
        {
            var merchantId = _accountService.GetLoggedInUserMerchantId() ?? 0;
            var orders = _context.Orders
                .Include(o => o.Items)
                    .ThenInclude(i => i.FoodItem)
                .Where(o => o.MerchantId == merchantId)
                .AsQueryable();

            if (fromDate.HasValue && toDate.HasValue)
            {
                // Date range
                orders = orders.Where(o =>
                    o.OrderDate.Date >= fromDate.Value.Date &&
                    o.OrderDate.Date <= toDate.Value.Date);
            }
            else if (fromDate.HasValue)
            {
                // Sirf From Date
                orders = orders.Where(o =>
                    o.OrderDate.Date == fromDate.Value.Date);
            }
            else if (toDate.HasValue)
            {
                // Sirf To Date
                orders = orders.Where(o =>
                    o.OrderDate.Date == toDate.Value.Date);
            }

            var result = await orders
                .OrderByDescending(o => o.OrderDate)
                .ToListAsync();

            return View(result);
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
        public async Task<IActionResult> dashboarddetails(int? id)
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

        [HttpPost]
        public async Task<IActionResult> Delete(int id)
        {
            var merchantId = _accountService.GetLoggedInUserMerchantId() ?? 0;
            var order = await _context.Orders.FirstOrDefaultAsync(o => o.Id == id && o.MerchantId == merchantId);
            if (order != null)
            {
                var orderItems = await _context.OrderItems.Where(oi => oi.OrderId == id).ToListAsync();
                _context.OrderItems.RemoveRange(orderItems);
                _context.Orders.Remove(order);
                await _context.SaveChangesAsync();
            }
            return RedirectToAction(nameof(Index));
        }
    }
}
