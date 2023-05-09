using ProniaApp.Models;

namespace ProniaApp.Areas.Admin.ViewModels.Product
{
    public class ProductDetailVM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int SaleCount { get; set; }
        public int StockCount { get; set; }
        public string ColorName { get; set; }
        public ICollection<ProductTag> TagNames { get; set; }
        public ICollection<ProductCategory> CategoryNames { get; set; }
        public ICollection<ProductSize> SizeNames { get; set; }
        public ICollection<ProductImage> Images { get; set; }
        public string MainImage { get; set; }
        public string HoverImage { get; set; }
    }
}
