using ProniaApp.Helpers;
using ProniaApp.Models;
using ProniaApp.ViewModels.Product;

namespace ProniaApp.ViewModels.Shop
{
    public class ShopVM
    {
        public IEnumerable<ProniaApp.Models.Product> Products { get; set; }
        public IEnumerable<Category> Categories { get; set; }
        public IEnumerable<Color> Colors { get; set; }
        public IEnumerable<Tag> Tags { get; set; }
        public Paginate<ProductVM> PaginateDatas { get; set; }
    }
}
