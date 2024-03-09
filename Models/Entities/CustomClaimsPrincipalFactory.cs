using FleaMarket.Models.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using System.Security.Claims;

namespace FleaMarket.Models.Entities
{
    public class CustomClaimsPrincipalFactory : UserClaimsPrincipalFactory<UserEntity>
    {
        private readonly UserManager<UserEntity> userManager;

        public CustomClaimsPrincipalFactory(UserManager<UserEntity> userManager, IOptions<IdentityOptions> optionsAccessor) : base(userManager, optionsAccessor)
        {
            this.userManager = userManager;
        }

        protected override async Task<ClaimsIdentity> GenerateClaimsAsync(UserEntity user)
        {
            var claimsIdentity = await base.GenerateClaimsAsync(user);

            claimsIdentity.AddClaim(new Claim("DisplayEmail", $"{user.Email}"));
            claimsIdentity.AddClaim(new Claim("Id", $"{user.Id}"));
            claimsIdentity.AddClaim(new Claim("CompanyName", $"{user.CompanyName}"));
            claimsIdentity.AddClaim(new Claim("UsersTableNumber", $"{user.TableNumber}"));

            return claimsIdentity;
        }
    }
}
