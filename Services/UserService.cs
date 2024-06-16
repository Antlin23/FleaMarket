using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using System.Linq.Expressions;
using FleaMarket.Models.Entities;
using FleaMarket.Contexts;
using Microsoft.EntityFrameworkCore;
using FleaMarket.Models.ViewModels;
using Microsoft.AspNetCore.Hosting;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.Processing;

namespace FleaMarket.Services
{
    public class UserService
    {
        private readonly DataContext _context;
        public UserService(DataContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<UserEntity>> GetAllUsersAsync()
        {
            // if I need to include something; Include(x => x.ProductTags).ThenInclude(x => x.Tag).
            IEnumerable<UserEntity> users = await _context.Users.ToListAsync();
            return users;
        }

        public async Task<IEnumerable<UserEntity>> GetAllActiveUsersAsync()
        {
            IEnumerable<UserEntity> activeUsers = await _context.Users.Where(x => x.IsActiveSeller == true).ToListAsync();

            return activeUsers;
        }

        public async Task<UserEntity> GetUserAsync(Expression<Func<UserEntity, bool>> expression)
        {
            // if I need to include something; Include(x => x.ProductTags).ThenInclude(x => x.Tag).
            var user = await _context.Users.FirstOrDefaultAsync(expression);
            return user!;
        }

        public async Task<bool> AddPlaceToUser(string userId, string place)
        {
            try
            {
                var user = await _context.Users.FirstOrDefaultAsync(x => x.Id == userId);

                user.Place = place;
                return true;
            }
            catch { return false; }
        }

        public async Task<bool> AddPlaceImageToUser(AddProductViewModel viewModel)
        {
            try
            {
                var user = await _context.Users.FirstOrDefaultAsync(x => x.Id == viewModel.UserId);

                if (viewModel.PlaceImage != null)
                {
                    user.PlaceImgUrl = $"{user.Id}_{viewModel.PlaceImage?.FileName}";
                }

                await _context.SaveChangesAsync();
                return true;
            }
            catch { return false; }
        }

        public async Task<bool> UpdatePlaceAsync(UpdatePlaceViewModel viewModel)
        {
            try
            {
                var user = await _context.Users.FirstOrDefaultAsync(x => x.Id == viewModel.UserId);
                user.Place = viewModel.NewPlace;

                if (viewModel.Image != null)
                {
                    user.PlaceImgUrl = $"{user.Id}_{viewModel.Image?.FileName}";
                }

                await _context.SaveChangesAsync();
                return true;
            }
            catch { return false; }
        }

        public async Task ResetUserPlacesAndActiveSeller()
        {
            IEnumerable<UserEntity> users = await GetAllUsersAsync();

            foreach (var user in users)
            {
                user.Place = null;
                user.PlaceImgUrl = null;
                user.IsActiveSeller = false;
            }
            await _context.SaveChangesAsync();
        }

        public async Task MakeUserActiveSellerAsync(string _userId)
        {
            var user = await GetUserAsync(x => x.Id == _userId);
            user.IsActiveSeller = true;
            await _context.SaveChangesAsync();
        }
    }
}
