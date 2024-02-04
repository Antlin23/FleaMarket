using FleaMarket.Models.Entities;

namespace FleaMarket.Models.ViewModels
{
    public class SearchProductViewModel
    {
        public string? SearchString { get; set; }
        public string? Category { get; set; }

        public IEnumerable<ProductEntity>? Products { get; set; }

        public string? NoProducts { get; set; }

    }
}
