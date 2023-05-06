using System.ComponentModel.DataAnnotations;

namespace ProniaApp.Areas.Admin.ViewModels.Testimonial
{
    public class TestimonialCreateVM
    {
        [Required(ErrorMessage ="Don`t be emtpy")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Don`t be emtpy")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Don`t be emtpy")]
        public string Profession { get; set; }

        [Required(ErrorMessage = "Don`t be emtpy")]
        public IFormFile Photo { get; set; }
    }
}
