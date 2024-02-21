﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using System.Linq.Expressions;
using FleaMarket.Models.Entities;
using FleaMarket.Contexts;
using Microsoft.EntityFrameworkCore;

namespace FleaMarket.Services
{
    public class UserService
    {
        private readonly DataContext _context;
        private readonly UserManager<UserEntity> _userManager;


        public UserService(DataContext context, UserManager<UserEntity> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public async Task<UserEntity> GetUserAsync(Expression<Func<UserEntity, bool>> expression)
        {
            // if I need to include something; Include(x => x.ProductTags).ThenInclude(x => x.Tag).
            var user = await _context.Users.FirstOrDefaultAsync(expression);
            return user!;
        }
    }
}
