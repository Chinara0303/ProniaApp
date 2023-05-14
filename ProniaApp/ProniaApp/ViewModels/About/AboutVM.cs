using ProniaApp.Models;

namespace ProniaApp.ViewModels.About
{
    public class AboutVM
    {
        public IEnumerable<Advert> Adverts { get; set; }
        public IEnumerable<Brand> Brands { get; set; }
    }
}
