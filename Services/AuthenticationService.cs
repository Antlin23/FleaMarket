using FleaMarket.Models.Entities;
using FleaMarket.Models.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace FleaMarket.Services
{
    public class AuthenticationService
    {
        private readonly UserManager<UserEntity> _userManager;
        private readonly SignInManager<UserEntity> _signInManager;

        public AuthenticationService(UserManager<UserEntity> userManager, SignInManager<UserEntity> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        public async Task<bool> RegisterUserAsync(RegisterUserViewModel viewModel)
        {
            try
            {
                if(viewModel.UserName == "company")
                {
                    viewModel.UserName = viewModel.UserName + Guid.NewGuid().ToString();
                    viewModel.UserName = viewModel.UserName.Replace("-", "_");
                }
                var result = await _userManager.CreateAsync(viewModel, viewModel.Password);

                if(result.Succeeded)
                {
                    var user = await _userManager.Users.FirstOrDefaultAsync(x => x.Email == viewModel.Email);
                    await _userManager.AddToRoleAsync(user, "user");
                    return true;

                }
            }
            catch (Exception ex) { Debug.WriteLine(ex.Message); }
            return false;
        }

        public async Task<bool> LoginAsync(LoginViewModel viewModel)
        {
            try
            {
                var newUser = await _userManager.FindByEmailAsync(viewModel.Email);

                var result = await _signInManager.PasswordSignInAsync(newUser.UserName, viewModel.Password, viewModel.RememberMe, false);
                return result.Succeeded;
            }
            catch (Exception ex) { Debug.WriteLine(ex.Message); }
            return false;
        }

        public async Task<bool> LogoutAsync()
        {
            try
            {
                await _signInManager.SignOutAsync();
                return true;
            }
            catch (Exception ex) { Debug.WriteLine(ex.Message); }
            return false;
        }
    }
}
