namespace ProniaApp.Models
{
    public class Banner:BaseEntity
    {
        public string SubTitle { get; set; }
        public string Title { get; set; }
        public string Image { get; set; }
        public bool IsLarge { get; set; } = false;
    }
}
