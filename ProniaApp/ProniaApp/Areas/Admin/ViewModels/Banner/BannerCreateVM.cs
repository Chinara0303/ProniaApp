using System.ComponentModel.DataAnnotations;

namespace ProniaApp.Areas.Admin.ViewModels.Banner
{
    public class BannerCreateVM
    {
        [Required(ErrorMessage ="Don`t be empty")]
        public string SubTitle { get; set; }

        [Required(ErrorMessage = "Don`t be empty")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Don`t be empty")]
        public IFormFile Photo { get; set; }

        public bool IsLarge { get; set; } = false;
    }
}
