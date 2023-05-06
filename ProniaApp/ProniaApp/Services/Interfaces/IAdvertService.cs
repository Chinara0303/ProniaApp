using ProniaApp.Models;

namespace ProniaApp.Services.Interfaces
{
    public interface IAdvertService
    {
        Task<IEnumerable<Advert>> GetAllAsync();
        Task<Advert> GetByIdAsync(int? id);
    }
}
