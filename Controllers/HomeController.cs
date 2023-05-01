using Microsoft.AspNetCore.Mvc;

namespace FleaMarket.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
