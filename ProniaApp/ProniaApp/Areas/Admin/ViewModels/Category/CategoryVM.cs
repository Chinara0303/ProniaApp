using System.ComponentModel.DataAnnotations;

namespace ProniaApp.Areas.Admin.ViewModels.Category
{
    public class CategoryVM
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Don`t be empty")]
        public string Name { get; set; }
    }
}
