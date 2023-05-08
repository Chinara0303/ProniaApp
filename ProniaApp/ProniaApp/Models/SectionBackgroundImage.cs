using System.ComponentModel.DataAnnotations.Schema;

namespace ProniaApp.Models
{
    public class SectionBackgroundImage:BaseEntity
    {
        public string Key { get; set; }
        public string Value { get; set; }
        [NotMapped]
        public IFormFile Photo { get; set; }
    }
}
