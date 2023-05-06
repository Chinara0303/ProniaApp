using System.ComponentModel.DataAnnotations;

namespace ProniaApp.Areas.Admin.ViewModels.Advert
{
    public class AdvertUpdateVM
    {
        public string Image { get; set; }

        public IFormFile Photo { get; set; }

        [Required(ErrorMessage = "Don`t be empty")]
        public string ShortDesc { get; set; }

        [Required(ErrorMessage = "Don`t be empty")]
        public string Title { get; set; }
    }
}
