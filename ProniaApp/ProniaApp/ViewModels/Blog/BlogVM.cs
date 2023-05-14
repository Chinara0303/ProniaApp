using ProniaApp.Helpers;
using ProniaApp.Models;

namespace ProniaApp.ViewModels.Blog
{
    public class BlogVM
    {
        public List<Models.Blog> Blogs { get; set; }
        public Models.Blog Blog { get; set; }
        public IEnumerable<Category> Categories { get; set; }
        public IEnumerable<Color> Colors { get; set; }
        public IEnumerable<Tag> Tags { get; set; }
        public IEnumerable<Models.Product> Products { get; set; }
        public Paginate<Models.Blog> PaginateDatas { get; set; }
        public BlogCommentVM BlogCommentVM { get; set; }

    }
}
