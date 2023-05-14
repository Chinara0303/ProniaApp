using ProniaApp.Models;

namespace ProniaApp.ViewModels.Product
{
    public class SingleProductVM
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public string SKU { get; set; }
        public int  Rating { get; set; }
        public string  Description { get; set; }
        public ICollection<ProductComment> ProductComments { get; set; }
        public ICollection<ProductCategory> ProductCategories { get; set; }
        public ICollection<ProductTag> ProductTags { get; set; }
        public ICollection<ProductImage> ProductImages { get; set; }
        public ICollection<ProductSize> ProductSizes { get; set; }
        public string ColorName { get; set; }
        public IEnumerable<Advert> Adverts { get; set; }
        public Dictionary<string,string> SectionBgs { get; set; }
        public IEnumerable<Models.Product> RelatedProducts { get; set; }
        public ProductCommentVM  ProductCommentVM { get; set; }
    }
}
