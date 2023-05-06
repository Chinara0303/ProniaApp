
using System.ComponentModel.DataAnnotations;

namespace ProniaApp.Areas.Admin.ViewModels.Tag
{
    public class TagVM
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Don`t be empty")]
        public string Name { get; set; }
    }
}
