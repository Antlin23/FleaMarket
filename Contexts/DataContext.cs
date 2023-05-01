using FleaMarket.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace FleaMarket.Contexts
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<ProductEntity> Products { get; set; }
    }
}
