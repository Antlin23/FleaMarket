using FleaMarket.Contexts;
using FleaMarket.Models;
using FleaMarket.Models.Entities;
using FleaMarket.Models.ViewModels;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.Processing;
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

        //gets market from database
        public async Task<MarketEntity> GetMarketAsync(Expression<Func<MarketEntity, bool>> expression)
        {
            // if I need to include something; Include(x => x.ProductTags).ThenInclude(x => x.Tag).
            var market = await _context.Markets.FirstOrDefaultAsync(expression);
            return market!;
        }


        //gets products from database
        public IEnumerable<ProductEntity> GetAllMarketProducts(Guid marketId)
        {
            return _context.Products.ToList().Where(x => x.MarketId == marketId);
        }

        //gets product with ID from database
        public async Task<ProductEntity> GetProductAsync(Expression<Func<ProductEntity, bool>> expression)
        {
            // if I need to include something; Include(x => x.ProductTags).ThenInclude(x => x.Tag).
            var product = await _context.Products.FirstOrDefaultAsync(expression);
            return product!;
        }

        //gets category products from database
        public async Task<SearchProductViewModel> GetProductsByFilterAsync(SearchProductViewModel viewModel)
        {
            IEnumerable<ProductEntity> marketProducts = new List<ProductEntity>();

            var _market = await GetMarketAsync(x => x.MarketTitle == viewModel.MarketName);

            marketProducts = GetAllMarketProducts(_market.Id);

            if (viewModel.Category != null && viewModel.Category != "Alla kategorier" && viewModel.SearchString != null)
            {
                viewModel.Products = marketProducts
                    .ToList()
                    .Where(x => x.Category == viewModel.Category && x.Title.ToLower().Contains(viewModel.SearchString.ToLower()));
            }
            else if (viewModel.Category == null || viewModel.Category == "Alla kategorier" && viewModel.SearchString != null)
            {
                viewModel.Products = marketProducts
                    .ToList()
                    .Where(x => x.Title.ToLower().Contains(viewModel.SearchString.ToLower()));
            }
            else if (viewModel.Category != null || viewModel.Category != "Alla kategorier" && viewModel.SearchString == null)
            {
                viewModel.Products = marketProducts
                    .ToList()
                    .Where(x => x.Category == viewModel.Category);
            }

            if (viewModel.Products == null) {
                viewModel.NoProducts = "No products was found";
            }

            return viewModel;
        }

        public async Task<ProductEntity> AddProduct(ProductEntity productEntity)
        {
            try
            {
                var newUser = await _userManager.Users.FirstOrDefaultAsync(x => x.Id == productEntity.UserId);

                productEntity.UserId = newUser.Id;

                _context.Products.Add(productEntity);
                await _context.SaveChangesAsync();
                return productEntity;
            }
            catch
            {
                return productEntity;
            }
        }

        public IEnumerable<ProductEntity> GetAllUserProducts(string userId)
        {
            return _context.Products.ToList().Where(x => x.UserId == userId);
        }

        public async Task<bool> DeleteProductAsync(Guid productId)
        {
            try
            {
                var _product = await _context.Products.FindAsync(productId);
                _context.Products.Remove(_product!);
                await _context.SaveChangesAsync();
                return true;
            }
            catch { return false; }
        }

    }
}
