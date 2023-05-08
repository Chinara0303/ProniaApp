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

        public void AddRangeToBlog(List<BlogImage> images)
        {
            _context.BlogImages.AddRange(images);
        }

        public async Task<IEnumerable<Blog>> GetAllAsync()
        {
            return await _context.Blogs.Include(b=>b.BlogImages).ToListAsync();
        }

        public async Task<Blog> GetBlogByImageId(int? id)
        {
            return await _context.Blogs.Include(b => b.BlogImages).FirstOrDefaultAsync(b => b.BlogImages.Any(bi => bi.Id == id));
        }

        public async Task<Blog> GetByIdAsync(int? id)
        {
            return await _context.Blogs.Include(b=>b.BlogImages).FirstOrDefaultAsync(b => b.Id == id);
        }

        public async Task<Blog> GetByIdTrackAsync(int? id)
        {
            return await _context.Blogs.AsNoTracking().Include(b => b.BlogImages).FirstOrDefaultAsync(b => b.Id == id);

        }

        public async Task<BlogImage> GetImageById(int? id)
        {
            return await _context.BlogImages.FirstOrDefaultAsync(b=>b.Id == id);
        }

        public void RemoveImage(BlogImage img)
        {
            _context.BlogImages.Remove(img);
        }

       
    }
}
