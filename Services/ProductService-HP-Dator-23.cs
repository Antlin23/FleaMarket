using FleaMarket.Contexts;
using FleaMarket.Models;
using FleaMarket.Models.Entities;
using FleaMarket.Models.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace FleaMarket.Services
{
    public class ProductService
    {
        private readonly DataContext _context;

        public ProductService(DataContext context)
        {
            _context = context;

        }

        //gets products from database
        public async Task<IEnumerable<ProductEntity>> GetAllAsync()
        {
            return await _context.Products.ToListAsync();
        }


        //gets "Ulva Kvarn" products from database 
        public IEnumerable<ProductEntity> GetUlvaKvarnAsync()
        {
            var products = _context.Products.ToList().Where(x => x.SelectMarket == "Ulva Kvarn");
            
            return products!;

        }


        public async Task<bool> AddProduct(ProductEntity productEntity)
        {
            try
            {
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
