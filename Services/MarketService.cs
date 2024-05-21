using FleaMarket.Contexts;
using FleaMarket.Models;
using FleaMarket.Models.Entities;
using FleaMarket.Models.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace FleaMarket.Services
{
    public class MarketService
    {
        private readonly DataContext _context;

        public MarketService(DataContext context)
        {
            _context = context;
        }

        //gets markets from database
        public async Task<IEnumerable<MarketEntity>> GetAllAsync()
        {
            return await _context.Markets.ToListAsync();
        }
        //register new market
        public async Task<MarketEntity> RegisterMarketAsync(MarketEntity entity)
        {
            try
            {
                await _context.Markets.AddAsync(entity);
                //might not need this one
                await _context.SaveChangesAsync();
                return entity;
            }
            catch
            {
                return entity;
            }
        }
    }
}
