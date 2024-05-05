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
        private readonly ImageService _imageService;
        public AccountController(UserService userService, ImageService imageService)
        {
            _userService = userService;
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

                    await _imageService.UploadUserPlaceImageAsync(entity, viewModel.Image);
                }
                return View();
            }
            catch
            {
                ModelState.AddModelError("", "Någon gick fel, försök igen eller kontakta oss.");
                return View();
            }
            
        }
    }
}
