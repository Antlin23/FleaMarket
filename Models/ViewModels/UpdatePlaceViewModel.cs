using System.ComponentModel.DataAnnotations;

namespace FleaMarket.Models.ViewModels
{
    public class UpdatePlaceViewModel
    {
        public string UserId { get; set; } = null!;
        public string NewPlace { get; set; } = null!;

        [Display(Name = "Bild")]
        [DataType(DataType.Upload)]
        public IFormFile? Image { get; set; }

    }
}
