using FleaMarket.Models.Entities;
using System.ComponentModel.DataAnnotations;

namespace FleaMarket.Models.ViewModels
{
    public class RegisterUserViewModel 
    {
        [Required(ErrorMessage = "Du måste ange ett användarnamn")]
        [StringLength(50, ErrorMessage = "Användarnamnet måste vara minst 3 tecken långt", MinimumLength = 3)]
        [RegularExpression(@"^(?!.*[öäå])[\w.]+$", ErrorMessage = "Användarnamnet får endast innehålla bokstäver (inte åäö), siffror, punkter och understreck.")]
        [Display(Name = "Användarnamn")] 
        public string UserName { get; set; } = null!;
        [Required(ErrorMessage = "Du måste ange din email-adress")]
        [RegularExpression(@"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$", ErrorMessage = "Ogiltig email-adress")]
        [Display(Name = "Email")]
        public string Email { get; set; } = null!;
        [Required(ErrorMessage = "Du måste ange ett lösenord")]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,}$", ErrorMessage = "Lösenordet måste innehålla minst 8 tecken, en stor bokstav, en liten bokstav, en siffra och ett specialtecken")]
        [Display(Name = "Lösenord")]
        public string Password { get; set; } = null!;
        [StringLength(50, ErrorMessage = "Ogiltigt företagsnamn", MinimumLength = 3)]
        [Display(Name = "Företagsnamn")]
        public string? CompanyName { get; set; }

        public static implicit operator UserEntity(RegisterUserViewModel viewModel)
        {
            return new UserEntity
            {
                UserName = viewModel.UserName,
                Email = viewModel.Email,
                CompanyName = viewModel.CompanyName,
            };
        }
    }
}
