using Microsoft.EntityFrameworkCore;
using ProniaApp.Data;
using ProniaApp.Models;
using ProniaApp.Services.Interfaces;

namespace ProniaApp.Services
{
    public class TagService : ITagService
    {
        private readonly AppDbContext _context;
        public TagService(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Tag>> GetAllAsync()
        {
            return await _context.Tags.Include(t=>t.ProductTags).ToListAsync();
        }

        public async Task<Tag> GetByIdAsync(int? id)
        {
            return await _context.Tags.AsNoTracking().FirstOrDefaultAsync(c => c.Id == id);

        }

        public bool CheckByName(string name)
        {
            return  _context.Tags.Any(c => c.Name.Trim().ToLower() == name.Trim().ToLower());
        }
    }
}
