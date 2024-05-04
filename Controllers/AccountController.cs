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

        public AccountController(UserService userService)
        {
            _userService = userService;
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

                    await _userService.UploadImageAsync(entity, viewModel.Image);
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
