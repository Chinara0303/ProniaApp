using Microsoft.EntityFrameworkCore;
using ProniaApp.Data;
using ProniaApp.Models;
using ProniaApp.Services.Interfaces;

namespace ProniaApp.Services
{
    public class BlogService : IBlogService
    {
        private readonly AppDbContext _context;
        public BlogService(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Blog>> GetAllAsync()
        {
            return await _context.Blogs.Include(b=>b.BlogImages).ToListAsync();
        }

        public async Task<Blog> GetByIdAsync(int? id)
        {
            return await _context.Blogs.Include(b=>b.BlogImages).FirstOrDefaultAsync(b => b.Id == id);
        }
    }
}
