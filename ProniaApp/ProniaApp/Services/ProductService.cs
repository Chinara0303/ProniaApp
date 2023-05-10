using Microsoft.EntityFrameworkCore;
using ProniaApp.Data;
using ProniaApp.Models;
using ProniaApp.Services.Interfaces;

namespace ProniaApp.Services
{
    public class ProductService : IProductService
    {

        private readonly AppDbContext _context;
        public ProductService(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Product>> GetAllAsync()
        {
            return await _context.Products.Include(p => p.ProductImages).ToListAsync();
        }

        public async Task<Product> GetByIdAsync(int? id)
        {
            return await _context.Products
                .Include(p => p.ProductCategories)
                .Include(p => p.ProductImages)
                .Include(p => p.ProductTags)
                .Include(p => p.ProductSizes)
                .FirstOrDefaultAsync(p => p.Id == id);
        }

        public async Task<int> GetCountAsync()
        {
            return await _context.Products.CountAsync();
        }

        public async Task<List<Product>> GetFullDataAsync()
        {
            return await _context.Products
                .Include(p => p.ProductImages)
                .Include(p => p.ProductCategories)
                .ThenInclude(pc => pc.Category)
                .Include(p => p.ProductTags)
                .ThenInclude(pt => pt.Tag)
                .Include(p => p.ProductSizes)
                .ThenInclude(ps => ps.Size)
                .Include(p => p.Color)
                .ToListAsync();
        }

        public async Task<Product> GetFullDataByIdAsync(int? id)
        {
            return await _context.Products.Include(p => p.ProductImages)
               .Include(p => p.ProductCategories)
               .ThenInclude(pc => pc.Category)
               .Include(p => p.ProductTags)
               .ThenInclude(pt => pt.Tag)
               .Include(p => p.ProductSizes)
               .ThenInclude(ps => ps.Size)
               .Include(p => p.Color)
               .FirstOrDefaultAsync(p => p.Id == id);
        }

        public async Task<ProductImage> GetImageById(int? id)
        {
            return await _context.ProductImages.FindAsync((int)id);
        }

        public async Task<List<Product>> GetPaginatedDatasAsync(int page, int take)
        {
            return await _context.Products
                .Include(p => p.ProductImages)
                .Include(p => p.ProductCategories)
                .ThenInclude(pc => pc.Category)
                .Include(p => p.ProductTags)
                .ThenInclude(pt => pt.Tag)
                .Include(p => p.ProductSizes)
                .ThenInclude(ps => ps.Size)
                .Include(p => p.Color)
                .Skip((page * take) - take)
                .Take(take)
                .ToListAsync();
        }

        public async Task<Product> GetProductByImageId(int? id)
        {
            return await _context.Products
                .Include(p => p.ProductImages)
                .FirstOrDefaultAsync(p => p.ProductImages.Any(p => p.Id == id));
        }

        public async Task<List<Product>> GetProductsByCategoryIdAsync(int? id)
        {
            return await _context.ProductCategories.Include(p=>p.Product).ThenInclude(p=>p.ProductImages).Where(pc => pc.Category.Id == id).Select(p=>p.Product).ToListAsync();
        }

        public async Task<List<Product>> GetProductsByColorIdAsync(int? id)
        {
            return await _context.Products.Include(p=>p.ProductImages).Include(c => c.Color).Where(p=>p.Color.Id==id).ToListAsync();
        }

        public async Task<List<Product>> GetProductsByTagIdAsync(int? id)
        {
            return await _context.ProductTags.Include(p => p.Product).ThenInclude(p => p.ProductImages).Where(pc => pc.Tag.Id == id).Select(p => p.Product).ToListAsync();
        }

        public void RemoveImage(ProductImage image)
        {
            _context.Remove(image);
        }
    }

}
