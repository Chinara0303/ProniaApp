using ProniaApp.Models;

namespace ProniaApp.Services.Interfaces
{
    public interface ISizeService
    {
        Task<IEnumerable<Size>> GetAllAsync();
        Task<Size> GetByIdAsync(int? id);
        bool CheckByName(string name);

    }
}
