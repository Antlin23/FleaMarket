using FleaMarket.Models.Entities;

namespace FleaMarket.Models.ViewModels
{
    public class RegisterUserViewModel
    {
        public string UserName { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string Password { get; set; } = null!;
        public string? CompanyName { get; set; }

        public static implicit operator UserEntity(RegisterUserViewModel viewModel)
        {
            return new UserEntity
            {
                UserName = viewModel.UserName,
                Email = viewModel.Email,
            };
        }
    }
}
