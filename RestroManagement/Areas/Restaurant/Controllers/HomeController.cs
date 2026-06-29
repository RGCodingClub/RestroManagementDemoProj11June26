using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace RestroManagement.Areas.Restaurant.Controllers
{
    [Area("Restaurant")]
    [Authorize(Roles = "Restaurant")]//Restaurant
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
