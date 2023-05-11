using ProniaApp.Helpers;
using ProniaApp.Models;
using ProniaApp.ViewModels.Product;

namespace ProniaApp.ViewModels.Blog
{
    public class BlogVM
    {
        public List<ProniaApp.Models.Blog> Blogs { get; set; }
        public ProniaApp.Models.Blog Blog { get; set; }
        public IEnumerable<Category> Categories { get; set; }
        public IEnumerable<Color> Colors { get; set; }
        public IEnumerable<Tag> Tags { get; set; }
        public Paginate<ProniaApp.Models.Blog> PaginateDatas { get; set; }
    }
}
