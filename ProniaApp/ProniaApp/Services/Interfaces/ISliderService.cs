using ProniaApp.Models;

namespace ProniaApp.Services.Interfaces
{
    public interface ISliderService
    {
        Task<IEnumerable<Slider>> GetAllAsync(); 
        Task<Slider> GetByIdAsync(int? id);
    }
}
