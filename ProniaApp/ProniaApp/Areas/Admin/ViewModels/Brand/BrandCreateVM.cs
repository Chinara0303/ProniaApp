using System.ComponentModel.DataAnnotations;

namespace ProniaApp.Areas.Admin.ViewModels.Brand
{
    public class BrandCreateVM
    {
        [Required(ErrorMessage ="Don`t be empty")]
        public List<IFormFile> Photos { get; set; }
    }
}
