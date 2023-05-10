using ProniaApp.Models;

namespace ProniaApp.Services.Interfaces
{
    public interface IColorService
    {
        Task<IEnumerable<Color>> GetAllAsync();
        Task<Color> GetByIdAsync(int? id);
        bool CheckByName(string name);
        
    }
}
