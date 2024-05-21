namespace FleaMarket.Models.Entities
{
    public class MarketEntity
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string MarketTitle { get; set; } = null!;
        public string ImageUrl { get; set; } = null!;
        public string City { get; set; } = null!;
        public string Address { get; set; } = null!;
        public string? TimeOpen { get; set; }
        public string? MapLink { get; set; }
        public string? MarketLink { get; set; }
        public string? marketDescription { get; set; }
    }
}
