using Microsoft.AspNetCore.Mvc;

namespace FleaMarket.Controllers
{
    public class DeniedController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
