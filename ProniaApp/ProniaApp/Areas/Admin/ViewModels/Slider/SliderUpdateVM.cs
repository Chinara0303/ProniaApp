using System.ComponentModel.DataAnnotations;

namespace ProniaApp.Areas.Admin.ViewModels.Slider
{
    public class SliderUpdateVM
    {
        public IFormFile Photo { get; set; }
        public string Image { get; set; }

        [Required(ErrorMessage = "Don`t be empty")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Don`t be empty")]
        public string Offer { get; set; }

        [Required(ErrorMessage = "Don`t be empty")]
        public string ShortDesc { get; set; }
    }
}
