namespace ProniaApp.Models
{
    public class Blog:BaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public ICollection<Comment> Comments { get; set; }
        public ICollection<BlogImage> BlogImages { get; set; }
    }
}
