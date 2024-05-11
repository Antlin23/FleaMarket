using FleaMarket.Models.Entities;
using FleaMarket.Models.ViewModels;
using FleaMarket.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FleaMarket.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AdminController : Controller
    {
        private readonly MarketService _marketService;
        private readonly ProductService _productService;

        public AdminController(MarketService marketService, ProductService productService)
        {
            _marketService = marketService;
            _productService = productService;
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

        [HttpPost]
        public async Task<IActionResult> DeleteAllProducts()
        {
            try
            {
                await _productService.DeleteAllProductsAsync();

                TempData["SuccessMessage"] = "Admin: Allas produkter togs bort";

                return RedirectToAction("Index", "Account");
            }
            catch
            {
                return View();
            }
        }
    }
}