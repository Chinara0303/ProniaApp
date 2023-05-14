
using ProniaApp.Models;

namespace ProniaApp.ViewModels.Home
{
    public class HomeVM
    {
        public IEnumerable<Models.Product> Products { get; set; }
        public IEnumerable<Slider> Sliders { get; set; }
        public IEnumerable<Banner> Banners { get; set; }
        public IEnumerable<Brand> Brands { get; set; }
        public IEnumerable<Models.Blog> Blogs { get; set; }
        public IEnumerable<Testimonial> Testimonials { get; set; }
        public IEnumerable<Advert> Adverts { get; set; }
    }
}
