using System.ComponentModel.DataAnnotations;

namespace FleaMarket.Models.ViewModels
{
    public class CreatePaymentViewModel
    {
        [Required(ErrorMessage = "Du måste ange ett telefonnummer")]
        [RegularExpression("^[0-9]{8,15}$", ErrorMessage = "Telefonnumret måste bestå av 8 till 15 siffror (ex. 4671234768)")]
        public string PayerPhoneNumber { get; set; } = null!;
    }
}
