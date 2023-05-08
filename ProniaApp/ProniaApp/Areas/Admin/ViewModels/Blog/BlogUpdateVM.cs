using ProniaApp.Models;
using System.ComponentModel.DataAnnotations;

namespace ProniaApp.Areas.Admin.ViewModels.Blog
{
    public class BlogUpdateVM
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Don`t be empty")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Don`t be empty")]
        public string Description { get; set; }

        public List<BlogImage> Images { get; set; }
        public List<IFormFile> Photos { get; set; }
    }
}
