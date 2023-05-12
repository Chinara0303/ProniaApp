namespace ProniaApp.Models
{
    public class BlogComment:BaseEntity
    {
        public string Name { get; set; }
        public string? Subject { get; set; }
        public string Message { get; set; }
        public string Email { get; set; }
        public int BlogId { get; set; }
        public Blog Blog { get; set; }
        public int AppUserId { get; set; }
        public AppUser AppUser { get; set; }
    }
}
