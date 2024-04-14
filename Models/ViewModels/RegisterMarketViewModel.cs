using FleaMarket.Models.Entities;
using System.ComponentModel.DataAnnotations;

namespace FleaMarket.Models.ViewModels
{
    public class RegisterMarketViewModel
    {
        [Required(ErrorMessage = "Du måste ange en titel på marknaden")]
        public string MarketTitle { get; set; } = null!;
        [Required(ErrorMessage = "Du måste ange vilken stad")]
        public string City { get; set; } = null!;
        [Required(ErrorMessage = "Du måste ange adressen hit, Ex. Storvägen 1, 123 45 Uppsala")]
        public string Address { get; set; } = null!;
        public string? TimeOpen { get; set; }
        public string? MapLink { get; set; }
        public string? MarketLink { get; set; }
        public string? MarketDescription { get; set; }

        public static implicit operator MarketEntity(RegisterMarketViewModel viewModel)
        {
            MarketEntity entity = new()
            {
                MarketTitle = viewModel.MarketTitle,
                City = viewModel.City,
                Address = viewModel.Address,
                TimeOpen = viewModel.TimeOpen,
                MapLink = viewModel.MapLink,
                MarketLink = viewModel.MarketLink,
                marketDescription = viewModel.MarketDescription
            };

            return entity;
        }
    }
}
