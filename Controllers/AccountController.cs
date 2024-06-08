using FleaMarket.Models.Entities;
using FleaMarket.Models.ViewModels;
using FleaMarket.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FleaMarket.Controllers
{
    [Authorize]
    public class AccountController : Controller
    {
        private readonly UserService _userService;
        private readonly ProductService _productService;
        private readonly ImageService _imageService;

        public AccountController(UserService userService, ProductService productService, ImageService imageService)
        {
            _userService = userService;
            _productService = productService;
            _imageService = imageService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(UpdatePlaceViewModel viewModel)
        {
            try
            {
                await _userService.UpdatePlaceAsync(viewModel);

                if (viewModel.Image != null)
                {
                    UserEntity entity = await _userService.GetUserAsync(x => x.UserName == User.Identity.Name);

                    //await _imageService.UploadUserPlaceImageAsync(entity, viewModel.Image);
                }
                return View();
            }
            catch
            {
                ModelState.AddModelError("", "Någon gick fel, försök igen eller kontakta oss.");
                return View();
            }
            
        }

        [HttpPost]
        public async Task<IActionResult> DeleteAllUserProducts()
        {
            try
            {
                UserEntity entity = await _userService.GetUserAsync(x => x.UserName == User.Identity.Name);

                await _productService.DeleteAllUserProductsAsync(entity.Id);

                TempData["SuccessMessage"] = "Alla produkter togs bort";

                return RedirectToAction("Index", "Account");
            }
            catch {
                return View();
            }
        }
    }
}
