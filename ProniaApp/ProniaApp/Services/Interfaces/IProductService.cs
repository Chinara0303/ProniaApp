using ProniaApp.Models;
using ProniaApp.ViewModels.Product;

namespace ProniaApp.Services.Interfaces
{
    public interface IProductService
    {
        Task<IEnumerable<Product>> GetAllAsync();
        Task<Product> GetByIdAsync(int? id);
        Task<List<Product>> GetFullDataAsync();
        Task<Product> GetFullDataByIdAsync(int? id);
        Task<ProductImage> GetImageById(int? id);
        Task<Product> GetProductByImageId(int? id);
        void RemoveImage(ProductImage image);
        Task<int> GetCountAsync();
        Task<List<Product>> GetPaginatedDatasAsync(int page,int take, int? categoryId, int? colorId, int? tagId);
        Task<List<ProductVM>> GetProductsByCategoryIdAsync(int? id, int page, int take);
        Task<List<ProductVM>> GetProductsByColorIdAsync(int? id);
        Task<List<ProductVM>> GetProductsByTagIdAsync(int? id);
        Task<IEnumerable<ProductVM>> GetDatasAsync();
        Task<int> GetProductsCountByCategoryAsync(int? catId);
        Task<int> GetProductsCountByColorAsync(int? colorId);
        Task<int> GetProductsCountByTagAsync(int? tagid);
        Task<IEnumerable<Product>> GetRelatedProducts();
        Task<List<Product>> GetAllBySearchText(string searchText);
        Task<List<ProductComment>> GetComments();
        Task<ProductComment> GetCommentByIdWithProduct(int? id);
        Task<ProductComment> GetCommentById(int? id);
    }
}
