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
        private readonly ImageService _imageService;
        public AdminController(MarketService marketService, ProductService productService, ImageService imageService)
        {
            _marketService = marketService;
            _productService = productService;
            _imageService = imageService;
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
                var entity = await _marketService.RegisterMarketAsync(viewModel);

                if (viewModel.Image != null)
                {
                    await _imageService.UploadMarketImageAsync(entity, viewModel.Image);
                }
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