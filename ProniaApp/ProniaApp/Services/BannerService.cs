using Microsoft.EntityFrameworkCore;
using ProniaApp.Data;
using ProniaApp.Models;
using ProniaApp.Services.Interfaces;

namespace ProniaApp.Services
{
    public class BannerService : IBannerService
    {
        private readonly AppDbContext _context;
        public BannerService(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Banner>> GetAllAsync()
        {
            return await _context.Banners.ToListAsync();
        }

        public async Task<Banner> GetByIdAsync(int? id)
        {
            return await _context.Banners.FirstOrDefaultAsync(c => c.Id == id);
        }
    }
}
