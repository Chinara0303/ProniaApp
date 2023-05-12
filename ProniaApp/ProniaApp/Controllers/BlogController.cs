using Microsoft.AspNetCore.Mvc;
using ProniaApp.Areas.Admin.ViewModels.Category;
using ProniaApp.Areas.Admin.ViewModels.Tag;
using ProniaApp.Helpers;
using ProniaApp.Models;
using ProniaApp.Services;
using ProniaApp.Services.Interfaces;
using ProniaApp.ViewModels.Blog;
using ProniaApp.ViewModels.Product;

namespace ProniaApp.Controllers
{
    public class BlogController : Controller
    {
        private readonly IBlogService _blogService;
        private readonly ICategoryService _categoryService;
        private readonly ITagService _tagService;
        private readonly IProductService _productService;
        private readonly ILayoutService _layoutService;
        public BlogController(IBlogService blogService, 
                              ILayoutService layoutService,
                              ITagService tagService,
                              ICategoryService categoryService,
                              IProductService productService)
        {
            _blogService = blogService;
            _layoutService = layoutService;
            _tagService = tagService;
            _categoryService = categoryService;
            _productService = productService;

        }
        public async Task<IActionResult> Index(int page = 1, int take = 2)
        {
            var blogs = await _blogService.GetAllAsync();
            List<Blog> datas = await _blogService.GetPaginatedDatasAsync(page, take);
            int pageCount = await GetPageCountAsync(take);
            Paginate<Blog> paginatedDatas = new(datas, page, pageCount);

            BlogVM model = new()
            {
                Blogs = blogs.ToList(),
                SectionBgs = _layoutService.GetSectionBackgroundImages(),
                PaginateDatas = paginatedDatas,
                Categories = await _categoryService.GetAllAsync(),
                Tags = await _tagService.GetAllAsync(),
                Products = await _productService.GetFullDataAsync()
            };
            return View(model);
        }
        private async Task<int> GetPageCountAsync(int take)
        {
             int prodCount = await _blogService.GetCountAsync();
            return (int)Math.Ceiling((decimal)prodCount / take);
        }

        
        [HttpGet]
        public async Task<IActionResult> SingleBlog(int? id)
        {
            if (id is null) return BadRequest();
            var dbBlog = await _blogService.GetByIdAsync((int)id);
            BlogVM model = new()
            {
                Blog = dbBlog,
            };
            return View(model);
        }
    }
}
