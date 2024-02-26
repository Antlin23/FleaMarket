using FleaMarket.Contexts;
using FleaMarket.Models;
using FleaMarket.Models.Entities;
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
    }
}
