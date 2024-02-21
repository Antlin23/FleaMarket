using FleaMarket.Models.Entities;
using FleaMarket.Models.ViewModels;
using FleaMarket.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FleaMarket.Controllers
{
    public class AuthenticationController : Controller
    {
        private readonly UserManager<UserEntity> _userManager;
        private readonly AuthenticationService _authenticationService;
        private readonly SignInManager<UserEntity> _signInManager;

        public AuthenticationController(UserManager<UserEntity> userManager, AuthenticationService authenticationService, SignInManager<UserEntity> signInManager)
        {
            _userManager = userManager;
            _authenticationService = authenticationService;
            _signInManager = signInManager;
        }

        public IActionResult RegisterUser()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> RegisterUser(RegisterUserViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                if(!await _userManager.Users.AnyAsync(x => x.Email == viewModel.Email))
                {
                    if(await _authenticationService.RegisterUserAsync(viewModel))
                    {
                        return RedirectToAction("LoginUser", "Authentication");
                    }
                }
            }
            return View();
        }

        public IActionResult LoginUser()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> LoginUser(LoginViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                if (await _authenticationService.LoginAsync(viewModel))
                {
                    return RedirectToAction("Index", "Home");
                }
                ModelState.AddModelError("", "Fel inloggningsuppgifter");
            }
            return View();
        }

        public async Task<IActionResult> LogoutUser()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }
    }
}
