using FleaMarket.Models.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace FleaMarket.Contexts
{
    public class DataContext : IdentityDbContext<UserEntity>
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<ProductEntity> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<IdentityRole>().HasData(
                new IdentityRole
                {
                    Id = "fcf9ba4c-3c7c-4a9b-abb2-083ae56904a4",
                    Name = "Admin",
                    NormalizedName = "ADMIN",
                    ConcurrencyStamp = Guid.NewGuid().ToString(),
                },
                new IdentityRole
                {
                    Id = "972b6232-0d25-46f9-a3e6-eec6fd127ff0",
                    Name = "User",
                    NormalizedName = "USER",
                    ConcurrencyStamp = Guid.NewGuid().ToString(),
                });

            var passwordHasher = new PasswordHasher<UserEntity>();
            var userEntity = new UserEntity
            {
                Id = "0cc0714b-7e95-47ff-9b50-460f04f29426",
                UserName = "admin",
                NormalizedUserName = "ADMIN",
                Email = "anton.jumkil@gmail.com",
                NormalizedEmail = "anton.jumkil@gmail.com",
            };

            userEntity.PasswordHash = passwordHasher.HashPassword(userEntity, "Alprodadmin123!");

            builder.Entity<UserEntity>().HasData(userEntity);

            builder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                UserId = userEntity.Id,
                RoleId = "fcf9ba4c-3c7c-4a9b-abb2-083ae56904a4"
            });
        }
    }
}
