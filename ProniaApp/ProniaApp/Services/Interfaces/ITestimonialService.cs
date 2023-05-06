using ProniaApp.Models;

namespace ProniaApp.Services.Interfaces
{
    public interface ITestimonialService
    {
        Task<IEnumerable<Testimonial>> GetAllAsync();
        Task<Testimonial> GetByIdAsync(int? id);
    }
}
