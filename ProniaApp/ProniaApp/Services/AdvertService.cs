using Microsoft.EntityFrameworkCore;
using ProniaApp.Data;
using ProniaApp.Models;
using ProniaApp.Services.Interfaces;

namespace ProniaApp.Services
{
    public class AdvertService : IAdvertService
    {
        private readonly AppDbContext _context;
        public AdvertService(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Advert>> GetAllAsync()
        {
           return  await _context.Adverts.ToListAsync();
        }

        public async Task<Advert> GetByIdAsync(int? id)
        {
            return await _context.Adverts.FirstOrDefaultAsync(a => a.Id == id);
        }
    }
}
       