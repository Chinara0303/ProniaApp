using Microsoft.EntityFrameworkCore;
using ProniaApp.Data;
using ProniaApp.Models;
using ProniaApp.Services.Interfaces;

namespace ProniaApp.Services
{
    public class ColorService : IColorService
    {
        private readonly AppDbContext _context;
        public ColorService(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Color>> GetAllAsync()
        {
            return await _context.Colors.ToListAsync();
        }

        public async Task<Color> GetByIdAsync(int? id)
        {
            return await _context.Colors.AsNoTracking().FirstOrDefaultAsync(c => c.Id == id);
        }
        public bool CheckByName(string name)
        {
            return _context.Colors.Any(c => c.Name.Trim().ToLower() == name.Trim().ToLower());
        }

    }
}
