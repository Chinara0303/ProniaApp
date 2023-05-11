using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ProniaApp.Data;
using ProniaApp.Models;
using ProniaApp.Services.Interfaces;
using ProniaApp.ViewModels.Product;

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
        public async Task<IEnumerable<ProductVM>> GetDatasAsync()
        {
            List<ProductVM> model = new();
            var products = await _context.Products.Include(p => p.ProductImages).ToListAsync();
            foreach (var item in products)
            {
                model.Add(new ProductVM
                {
                    Id = item.Id,
                    Price = item.Price,
                    Name = item.Name,
                    ProductImages = item.ProductImages,
                    Rating = item.Rating
                });
            }
            return model;
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

        public async Task<List<Product>> GetPaginatedDatasAsync(int page, int take, int? categoryId, int? colorId, int? tagId)
        {
            if (categoryId != null)
            {
                return await _context.ProductCategories
                .Include(p => p.Product)
                .ThenInclude(p => p.ProductImages)
                .Where(pc => pc.Category.Id == categoryId)
                .Select(p => p.Product)
                .Skip((page * take) - take)
                .Take(take)
                .ToListAsync();
            }
            if (colorId != null)
            {
                return await _context.Products
                .Include(p => p.ProductImages)
                .Include(c => c.Color)
                .Where(p => p.Color.Id == colorId)
                .Skip((page * take) - take)
                .Take(take)
                .ToListAsync();
            }
            if (tagId != null)
            {
                return await _context.ProductTags
                .Include(p => p.Product)
                .ThenInclude(p => p.ProductImages)
                .Where(pc => pc.Tag.Id == tagId)
                .Skip((page * take) - take)
                .Take(take)
                .Select(p => p.Product)
                .ToListAsync();
            }
            else
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

        }

        public async Task<Product> GetProductByImageId(int? id)
        {
            return await _context.Products
                .Include(p => p.ProductImages)
                .FirstOrDefaultAsync(p => p.ProductImages.Any(p => p.Id == id));
        }

        public async Task<List<ProductVM>> GetProductsByCategoryIdAsync(int? id, int page = 1, int take = 6)
        {
            List<ProductVM> model = new();
            var products = await _context.ProductCategories
                .Include(p => p.Product)
                .ThenInclude(p => p.ProductImages)
                .Where(pc => pc.Category.Id == id)
                .Select(p => p.Product)
                .Skip((page * take) - take)
                .Take(take)
                .ToListAsync();

            foreach (var item in products)
            {
                model.Add(new ProductVM
                {
                    Id = item.Id,
                    Price = item.Price,
                    Name = item.Name,
                    ProductImages = item.ProductImages,
                    Rating = item.Rating
                });
            }
            return model;


        }

        public async Task<List<ProductVM>> GetProductsByColorIdAsync(int? id)
        {
            List<ProductVM> model = new();
            var products = await _context.Products
                .Include(p => p.ProductImages)
                .Include(c => c.Color)
                .Where(p => p.Color.Id == id)
                .ToListAsync();

            foreach (var item in products)
            {
                model.Add(new ProductVM
                {
                    Id = item.Id,
                    Price = item.Price,
                    Name = item.Name,
                    ProductImages = item.ProductImages,
                    Rating = item.Rating
                });
            }
            return model;
        }

        public async Task<List<ProductVM>> GetProductsByTagIdAsync(int? id)
        {
            List<ProductVM> model = new();
            var products = await _context.ProductTags
                .Include(p => p.Product)
                .ThenInclude(p => p.ProductImages)
                .Where(pc => pc.Tag.Id == id)
                .Select(p => p.Product)
                .ToListAsync();

            foreach (var item in products)
            {
                model.Add(new ProductVM
                {
                    Id = item.Id,
                    Price = item.Price,
                    Name = item.Name,
                    ProductImages = item.ProductImages,
                    Rating = item.Rating
                });
            }
            return model;
        }

        public void RemoveImage(ProductImage image)
        {
            _context.Remove(image);
        }

        public async Task<int> GetProductsCountByCategoryAsync(int? id)
        {
            return await _context.ProductCategories
                 .Include(p => p.Product)
                 .ThenInclude(p => p.ProductImages)
                 .Where(pc => pc.Category.Id == id)
                 .Select(p => p.Product)
                 .CountAsync();
        }

        public async Task<int> GetProductsCountByColorAsync(int? id)
        {
            return await _context.Products
                   .Include(p => p.ProductImages)
                   .Include(c => c.Color)
                   .Where(p => p.Color.Id == (int)id)
                   .CountAsync();
        }

        public async Task<int> GetProductsCountByTagAsync(int? id)
        {
            return await _context.ProductTags
                  .Include(p => p.Product)
                  .ThenInclude(p => p.ProductImages)
                  .Where(pc => pc.Tag.Id == (int)id)
                  .Select(p => p.Product)
                  .CountAsync();
        }

        public async Task<IEnumerable<Product>> GetRelatedProducts()
        {
           return await _context.Products
                .Include(p=>p.ProductImages)
                .OrderByDescending(p=>p.Color.Name)
                .ToListAsync();
        }
    }

}
