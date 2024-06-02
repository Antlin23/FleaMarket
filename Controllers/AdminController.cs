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
        private readonly UserService _userService;

        public AdminController(MarketService marketService, ProductService productService, ImageService imageService, UserService userService)
        {
            _marketService = marketService;
            _productService = productService;
            _imageService = imageService;
            _userService = userService;
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
        public async Task<IActionResult> DailyReset()
        {
            try
            {
                await _productService.DeleteAllProductsAsync();
                await _userService.ResetUserPlacesAndActiveSeller();

                TempData["SuccessMessage"] = "Admin: Allting återställdes";

                return RedirectToAction("Index", "Account");
            }
            catch
            {
                return View();
            }
        }
    }
}