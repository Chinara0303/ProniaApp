namespace ProniaApp.Models
{
    public class BlogImage:BaseEntity
    {
        public string ImgName { get; set; }
        public bool IsMain { get; set; } = false;
        public int BlogId { get; set; }
        public Blog Blog { get; set; }
    }
}
