using FleaMarket.Models.Entities;
using FleaMarket.Models.ViewModels;
using FleaMarket.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.EntityFrameworkCore;
using System.Text;
using System.Web;

namespace FleaMarket.Controllers
{
    public class AuthenticationController : Controller
    {
        private readonly UserManager<UserEntity> _userManager;
        private readonly AuthenticationService _authenticationService;
        private readonly SignInManager<UserEntity> _signInManager;
        private readonly SendGridService _sendGridService;

        public AuthenticationController(UserManager<UserEntity> userManager, AuthenticationService authenticationService, SignInManager<UserEntity> signInManager, SendGridService sendGridService)
        {
            _userManager = userManager;
            _authenticationService = authenticationService;
            _signInManager = signInManager;
            _sendGridService = sendGridService;
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
        [ValidateAntiForgeryToken]
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
                        var user = await _userManager.FindByEmailAsync(viewModel.Email);
                        var token = await _userManager.GenerateEmailConfirmationTokenAsync(user);
                        var encodedToken = WebEncoders.Base64UrlEncode(Encoding.UTF8.GetBytes(token));

                        var confirmationLink = Url.Action(nameof(ConfirmEmail), "Authentication", new { encodedToken, email = viewModel.Email }, Request.Scheme);
                        await _sendGridService.SendEmailAsync(confirmationLink, user);

                        return RedirectToAction(nameof(SuccessRegistration));

                        //login efter registration
                        /*LoginViewModel loginViewModel = new LoginViewModel();

                        loginViewModel.Password = viewModel.Password;
                        loginViewModel.Email = viewModel.Email;

                        if (await _authenticationService.LoginAsync(loginViewModel))
                        {
                            TempData["SuccessMessage"] = "Välkommen, kul att du ville skapa ett konto hos oss. " +
                                "Här på sidan Mitt Konto kan du aktivera ditt säljkonto, lägga upp och ta bort produkter. " +
                                "Lycka till med försäljningen!";
                            return RedirectToAction("Index", "Account");
                        }
                        */
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

        [HttpGet]
        public async Task<IActionResult> ConfirmEmail(string encodedToken, string email)
        {
            var user = await _userManager.FindByEmailAsync(email);
            if (user == null)
                return View("Error");

            var decodedToken = Encoding.UTF8.GetString(WebEncoders.Base64UrlDecode(encodedToken));
            var result = await _userManager.ConfirmEmailAsync(user, decodedToken); return View(result.Succeeded ? nameof(ConfirmEmail) : "Error");
        }
        [HttpGet]
        public IActionResult SuccessRegistration()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Error()
        {
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
