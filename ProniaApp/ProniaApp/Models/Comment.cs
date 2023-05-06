namespace ProniaApp.Models
{
    public class Comment:BaseEntity
    {
        public string Description { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int BlogId { get; set; }
        public Blog Blog { get; set; }
        public int AppUserId { get; set; }
        public AppUser AppUser { get; set; }

    }
}
