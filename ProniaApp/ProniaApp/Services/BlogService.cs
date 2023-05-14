﻿using Microsoft.EntityFrameworkCore;
using ProniaApp.Data;
using ProniaApp.Models;
using ProniaApp.Services.Interfaces;
using System.Linq;

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
            return await _context.Blogs.Include(b=>b.BlogImages).Include(b=>b.BlogComments).ToListAsync();
        }

        public async Task<Blog> GetBlogByImageId(int? id)
        {
            return await _context.Blogs.Include(b => b.BlogImages).FirstOrDefaultAsync(b => b.BlogImages.Any(bi => bi.Id == id));
        }

        public async Task<Blog> GetByIdAsync(int? id)
        {
            return await _context.Blogs.Include(b=>b.BlogImages).Include(b=>b.BlogComments).FirstOrDefaultAsync(b => b.Id == id);
        }

        public async Task<Blog> GetByIdTrackAsync(int? id)
        {
            return await _context.Blogs.AsNoTracking().Include(b => b.BlogImages).FirstOrDefaultAsync(b => b.Id == id);
        }

        public async Task<BlogComment> GetCommentById(int? id)
        {
            return await _context.BlogComments.FindAsync(id);
        }

        public async Task<BlogComment> GetCommentByIdWithBlog(int? id)
        {
            return await _context.BlogComments.Include(b => b.Blog).FirstOrDefaultAsync(b => b.Id == id);
        }

        public async Task<List<BlogComment>> GetComments()
        {
            return await _context.BlogComments.Include(b=>b.Blog).ToListAsync();
        }

        public async Task<int> GetCountAsync()
        {
            return await _context.Blogs.CountAsync();
        }

        public async Task<BlogImage> GetImageById(int? id)
        {
            return await _context.BlogImages.FirstOrDefaultAsync(b=>b.Id == id);
        }

        public async Task<List<Blog>> GetPaginatedDatasAsync(int page = 1, int take = 2)
        {
            return await _context.Blogs
                .Include(b => b.BlogImages)
                .Include(b=>b.BlogComments)
                .Skip((page * take) - take)
                .Take(take)
                .ToListAsync();
        }

        public void RemoveImage(BlogImage img)
        {
            _context.BlogImages.Remove(img);
        }

       
    }
}
