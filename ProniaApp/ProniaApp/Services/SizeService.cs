using Microsoft.EntityFrameworkCore;
using ProniaApp.Data;
using ProniaApp.Models;
using ProniaApp.Services.Interfaces;

namespace ProniaApp.Services
{
    public class SizeService : ISizeService
    {
        private readonly AppDbContext _context;
        public SizeService(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Size>> GetAllAsync()
        {
            return await _context.Sizes.ToListAsync();
        }

        public async Task<Size> GetByIdAsync(int? id)
        {
            return await  _context.Sizes.AsNoTracking().FirstOrDefaultAsync(c => c.Id == id);

        }
        public bool CheckByName(string name)
        {
            return _context.Sizes.Any(c => c.Name.Trim().ToLower() == name.Trim().ToLower());
        }

    }
}
