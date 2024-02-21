using Microsoft.AspNetCore.Identity;

namespace FleaMarket.Models.Entities
{
    public class UserEntity : IdentityUser
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? CompanyName { get; set; }

        public ICollection<ProductEntity> Products { get; set; } = new HashSet<ProductEntity>();
    }
}
