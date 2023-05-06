using System.ComponentModel.DataAnnotations;

namespace ProniaApp.Areas.Admin.ViewModels.Testimonial
{
    public class TestimonialUpdateVM
    {
        [Required(ErrorMessage = "Don`t be emtpy")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Don`t be emtpy")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Don`t be emtpy")]
        public string Profession { get; set; }

        public IFormFile Photo { get; set; }
        public string Image { get; set; }
    }
}
