using ProniaApp.Models;
using System.ComponentModel.DataAnnotations;

namespace ProniaApp.Areas.Admin.ViewModels.Product
{
    public class ProductUpdateVM
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Don`t be empty")]
        public string Name { get; set; }
        public string SKU { get; set; }

        [Required(ErrorMessage = "Don`t be empty")]
        public int  Rating { get; set; }

        [Required(ErrorMessage = "Don`t be empty")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Don`t be empty")]
        public decimal Price { get; set; }

        [Required(ErrorMessage = "Don`t be empty")]
        public int SaleCount { get; set; }

        [Required(ErrorMessage = "Don`t be empty")]
        public int StockCount { get; set; }
        public List<IFormFile> Photos { get; set; }
        public ICollection<ProductImage> ProductImages { get; set; }

        public int ColorId { get; set; }
        public ICollection<ProductTag> TagNames { get; set; }
        public List<int> TagIds { get; set; } = new();

        public ICollection<ProductCategory> CategoryNames { get; set; }
        public List<int> CategoryIds { get; set; } = new();

        public ICollection<ProductSize> SizeNames { get; set; }

        public List<int> SizeIds { get; set; } = new();
    }

}
