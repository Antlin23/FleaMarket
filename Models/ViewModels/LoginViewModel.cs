using System.ComponentModel.DataAnnotations;

namespace FleaMarket.Models.ViewModels
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Du måste ange din email-adress")]
        [RegularExpression(@"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$", ErrorMessage = "Ogiltig email-adress")]
        [Display(Name = "Email")]
        public string Email { get; set; } = null!;
        [Required(ErrorMessage = "Du måste ange ditt lösenord")]
        [Display(Name = "Lösenord")]
        public string Password { get; set; } = null!;
        public bool RememberMe { get; set; } = true;
    }
}
