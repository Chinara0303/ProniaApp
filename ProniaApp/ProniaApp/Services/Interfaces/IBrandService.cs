using ProniaApp.Models;

namespace ProniaApp.Services.Interfaces
{
    public interface IBrandService
    {
        Task<IEnumerable<Brand>> GetAllAsync();
        Task<Brand> GetByIdAsync(int? id);
    }
}
