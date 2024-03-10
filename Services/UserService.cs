using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using System.Linq.Expressions;
using FleaMarket.Models.Entities;
using FleaMarket.Contexts;
using Microsoft.EntityFrameworkCore;
using FleaMarket.Models.ViewModels;

namespace FleaMarket.Services
{
    public class UserService
    {
        private readonly DataContext _context;


        public UserService(DataContext context)
        {
            _context = context;
        }

        public async Task<UserEntity> GetUserAsync(Expression<Func<UserEntity, bool>> expression)
        {
            // if I need to include something; Include(x => x.ProductTags).ThenInclude(x => x.Tag).
            var user = await _context.Users.FirstOrDefaultAsync(expression);
            return user!;
        }

        public async Task<bool> AddTableNumberToUser(string userId, int tableNumber)
        {
            try
            {
                var user = await _context.Users.FirstOrDefaultAsync(x => x.Id == userId);

                user.TableNumber = tableNumber;
                return true;
            }
            catch { return false; }
        }

        public async Task<bool> UpdateTableNumberAsync(UpdateTableNumberViewModel viewModel)
        {
            try
            {
                var user = await _context.Users.FirstOrDefaultAsync(x => x.Id == viewModel.UserId);

                user.TableNumber = viewModel.NewTableNumber;

                await _context.SaveChangesAsync();
                return true;
            }
            catch { return false; }
        }
    }
}
