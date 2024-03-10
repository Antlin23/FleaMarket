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
        public async Task<IActionResult> Index(UpdateTableNumberViewModel viewModel)
        {
            try
            {
                await _userService.UpdateTableNumberAsync(viewModel);
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
