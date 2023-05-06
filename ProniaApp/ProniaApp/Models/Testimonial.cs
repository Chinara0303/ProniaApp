namespace ProniaApp.Models
{
    public class Testimonial:BaseEntity
    {
        public string Name { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }
        public string Profession { get; set; }
    }
}
