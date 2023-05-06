using System.ComponentModel.DataAnnotations;

namespace ProniaApp.Areas.Admin.ViewModels.Slider
{
    public class SliderCreateVM
    {
        [Required(ErrorMessage = "Don`t be empty")]
        public IFormFile Photo { get; set; }

        [Required(ErrorMessage = "Don`t be empty")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Don`t be empty")]
        public string Offer { get; set; }

        [Required(ErrorMessage = "Don`t be empty")]
        public string ShortDesc { get; set; }
    }
}
