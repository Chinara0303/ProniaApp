using ProniaApp.Models;

namespace ProniaApp.Services.Interfaces
{
    public interface ITagService
    {
        Task<IEnumerable<Tag>> GetAllAsync();
        Task<Tag> GetByIdAsync(int? id);
    }
}
