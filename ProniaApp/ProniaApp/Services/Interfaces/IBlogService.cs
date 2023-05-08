using ProniaApp.Models;

namespace ProniaApp.Services.Interfaces
{
    public interface IBlogService
    {
        Task<IEnumerable<Blog>> GetAllAsync();
        Task<Blog> GetByIdAsync(int? id);
    }
}
