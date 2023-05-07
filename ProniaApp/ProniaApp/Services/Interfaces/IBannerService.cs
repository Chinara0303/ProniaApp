using ProniaApp.Models;

namespace ProniaApp.Services.Interfaces
{
    public interface IBannerService
    {
        Task<IEnumerable<Banner>> GetAllAsync();
        Task<Banner> GetByIdAsync(int? id);
    }
}
