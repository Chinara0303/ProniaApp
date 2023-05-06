using Microsoft.EntityFrameworkCore;
using ProniaApp.Data;
using ProniaApp.Models;
using ProniaApp.Services.Interfaces;

namespace ProniaApp.Services
{
    public class TestimonialService : ITestimonialService
    {
        private readonly AppDbContext _context;
        public TestimonialService(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Testimonial>> GetAllAsync()
        {
            return await _context.Testimonials.ToListAsync();
        }

        public async Task<Testimonial> GetByIdAsync(int? id)
        {
            return await _context.Testimonials.FirstOrDefaultAsync(c => c.Id == id);
        }
    }
}
