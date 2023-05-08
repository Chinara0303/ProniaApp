using ProniaApp.Models;

namespace ProniaApp.Areas.Admin.ViewModels.Blog
{
    public class BlogDetailVM
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public string Description { get; set; }

        public List<BlogImage> Images { get; set; }
    }
}
