using ProniaApp.Models;

namespace ProniaApp.Services.Interfaces
{
    public interface IProductService
    {
        Task<List<Product>> GetAllAsync();
        Task<Product> GetByIdAsync(int? id);
        Task<List<Product>> GetFullDataAsync();
        Task<Product> GetFullDataByIdAsync(int? id);
        Task<ProductImage> GetImageById(int? id);
        Task<Product> GetProductByImageId(int? id);

        void RemoveImage(ProductImage image);
        Task<int> GetCountAsync();
        Task<List<Product>> GetPaginatedDatasAsync(int page,int take);

    }
}
