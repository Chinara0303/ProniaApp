namespace ProniaApp.Models
{
    public class Blog:BaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public ICollection<Comment> Comments { get; set; }
        public List<BlogImage> BlogImages { get; set; }
    }
}
