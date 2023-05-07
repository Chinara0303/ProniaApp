using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProniaApp.Models
{
    public class Setting:BaseEntity
    {
        public string Key { get; set; }
        public string Value { get; set; }

        [NotMapped]
        public IFormFile LogoPhoto { get; set; }

        [NotMapped]
        public IFormFile PaymentPhoto { get; set; }
    }
}
