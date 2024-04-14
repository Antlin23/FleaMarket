using FleaMarket.Models.ViewModels;
using FleaMarket.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FleaMarket.Controllers
{
    [Authorize]
    public class AdminController : Controller
    {
        private readonly MarketService _marketService;

        public AdminController(MarketService marketService)
        {
            _marketService = marketService;
        }

        public IActionResult RegisterMarket()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> RegisterMarket(RegisterMarketViewModel viewModel)
        {
            if(ModelState.IsValid)
            {
                await _marketService.RegisterMarketAsync(viewModel);
                return RedirectToAction("Index", "Account");
            }
            return View(viewModel);
        }
    }
}