using System.ComponentModel.DataAnnotations;

namespace ProniaApp.Areas.Admin.ViewModels.Banner
{
    public class BannerUpdateVM
    {
        [Required(ErrorMessage = "Don`t be empty")]
        public string SubTitle { get; set; }

        [Required(ErrorMessage = "Don`t be empty")]
        public string Title { get; set; }

        public IFormFile Photo { get; set; }
        public string Image { get; set; }

        public bool IsLarge { get; set; } = false;
    }
}
