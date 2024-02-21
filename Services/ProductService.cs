﻿using FleaMarket.Contexts;
using FleaMarket.Models;
using FleaMarket.Models.Entities;
using FleaMarket.Models.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace FleaMarket.Services
{
    public class ProductService
    {
        private readonly DataContext _context;
        private readonly UserManager<UserEntity> _userManager;

        public ProductService(DataContext context, UserManager<UserEntity> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        //gets products from database
        public async Task<IEnumerable<ProductEntity>> GetAllAsync()
        {
            return await _context.Products.ToListAsync();
        }

        //gets category products from database
        public SearchProductViewModel GetProductsByFilter(SearchProductViewModel viewModel)
        {
            if(viewModel.Category != null && viewModel.Category != "Alla kategorier" && viewModel.SearchString != null)
            {
                viewModel.Products = _context.Products
                    .ToList()
                    .Where(x => x.Category == viewModel.Category && x.Title.ToLower().Contains(viewModel.SearchString.ToLower()));
            }
            else if (viewModel.Category == null || viewModel.Category == "Alla kategorier" && viewModel.SearchString != null)
            {
                viewModel.Products = _context.Products
                    .ToList()
                    .Where(x => x.Title.ToLower().Contains(viewModel.SearchString.ToLower()));
            }
            else if (viewModel.Category != null || viewModel.Category != "Alla kategorier" && viewModel.SearchString == null)
            {
                viewModel.Products = _context.Products
                    .ToList()
                    .Where(x => x.Category == viewModel.Category);
            }

            if (viewModel.Products == null) {
                viewModel.NoProducts = "No products was found";
            }

            return viewModel;
        }

        //gets Ulva Kvarn products from database
        public IEnumerable<ProductEntity> GetUlvaKvarn()
        {
            return _context.Products.ToList().Where(x => x.SelectMarket == "Ulva Kvarn");
        }

        //gets Vaksala Torg products from database
        public IEnumerable<ProductEntity> GetVaksalaTorg()
        {
            return _context.Products.ToList().Where(x => x.SelectMarket == "Vaksala Torg");
        }


        public async Task<bool> AddProduct(ProductEntity productEntity)
        {
            try
            {
                var newUser = await _userManager.Users.FirstOrDefaultAsync(x => x.UserName == productEntity.UserId);

                productEntity.UserId = newUser.Id;

                _context.Products.Add(productEntity);
                await _context.SaveChangesAsync();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
