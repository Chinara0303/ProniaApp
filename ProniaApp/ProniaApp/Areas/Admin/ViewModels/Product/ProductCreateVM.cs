using System.ComponentModel.DataAnnotations;

namespace ProniaApp.Areas.Admin.ViewModels.Product
{
    public class ProductCreateVM
    {
        [Required(ErrorMessage = "Don`t be empty")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Don`t be empty")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Don`t be empty")]
        public string Price { get; set; }

        [Required(ErrorMessage = "Don`t be empty")]
        public int SaleCount { get; set; }

        [Required(ErrorMessage = "Don`t be empty")]
        public int StockCount { get; set; }

        [Required(ErrorMessage = "Don`t be empty")]
        public IFormFile MainPhoto { get; set; }

        [Required(ErrorMessage = "Don`t be empty")]
        public IFormFile HoverPhoto { get; set; }

        [Required(ErrorMessage = "Don`t be empty")]
        public List<IFormFile> Photos { get; set; }

        public int ColorId { get; set; }
        [Required(ErrorMessage = "Don`t be empty")]

        public List<int> TagIds { get; set; } = new();
        [Required(ErrorMessage = "Don`t be empty")]

        public List<int> CategoryIds { get; set; } = new();
        [Required(ErrorMessage = "Don`t be empty")]

        public List<int> SizeIds { get; set; } = new();
    }
}
