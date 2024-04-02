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

        public IActionResult RegisterCompany()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> RegisterUser(RegisterUserViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                if(await _userManager.Users.AnyAsync(x => x.UserName == viewModel.UserName))
                {
                    if(viewModel.UserName == "company" && (viewModel.CompanyName != null && viewModel.CompanyName != ""))
                    {
                        if (await _authenticationService.RegisterUserAsync(viewModel))
                        {
                            return RedirectToAction("LoginUser", "Authentication");
                        }
                    }
                    ModelState.AddModelError("", "Användarnamnet är redan upptaget");
                    return View();
                }
                if(!await _userManager.Users.AnyAsync(x => x.Email == viewModel.Email))
                {
                    if(await _authenticationService.RegisterUserAsync(viewModel))
                    {
                        LoginViewModel loginViewModel = new LoginViewModel();

                        loginViewModel.Password = viewModel.Password;
                        loginViewModel.Email = viewModel.Email;

                        if (await _authenticationService.LoginAsync(loginViewModel))
                        {
                            TempData["SuccessMessage"] = "Välkommen, kul att du ville skapa ett konto hos oss. " +
                                "Här på sidan Mitt Konto kan du aktivera ditt säljkonto, lägga upp och ta bort produkter. " +
                                "Lycka till med försäljningen!";
                            return RedirectToAction("Index", "Account");
                        }
                    }
                }
                else
                {
                    ModelState.AddModelError("", "Emailadressen finns redan registrerad");
                    return View();
                }
            }
            ModelState.AddModelError("", "Något blev fel. Var vänlig testa igen.");
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
                    return RedirectToAction("Index", "Account");
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
