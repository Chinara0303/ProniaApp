using Microsoft.AspNetCore.Authorization;
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
        private readonly ICrudService<BlogComment> _crudService;
        public BlogController(IBlogService blogService, 
                              ILayoutService layoutService,
                              ITagService tagService,
                              ICategoryService categoryService,
                              IProductService productService,
                              ICrudService<BlogComment> crudService)
        {
            _blogService = blogService;
            _layoutService = layoutService;
            _tagService = tagService;
            _categoryService = categoryService;
            _productService = productService;
            _crudService = crudService;
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
                PaginateDatas = paginatedDatas,
                Categories = await _categoryService.GetAllAsync(),
                Tags = await _tagService.GetAllAsync(),
                Products = await _productService.GetFullDataAsync(),
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
            if (dbBlog is null) return NotFound();
            var blogs = await _blogService.GetAllAsync();

            BlogVM model = new()
            {
                Blog = dbBlog,
                Blogs = blogs.ToList(),
                Categories = await _categoryService.GetAllAsync(),
                Tags = await _tagService.GetAllAsync(),
                Products = await _productService.GetFullDataAsync(),
            };
            return View(model);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public async Task<IActionResult> PostComment(BlogVM model, int? id, string userId)
        {
            if (id is null || userId == null) return BadRequest();
            if (!ModelState.IsValid) return RedirectToAction(nameof(SingleBlog), new { id });

            BlogComment blogComment = new()
            {
                Name = model.BlogCommentVM.Name,
                Email = model.BlogCommentVM.Email,
                Subject = model.BlogCommentVM.Subject,
                Message = model.BlogCommentVM.Message,
                AppUserId = userId,
                BlogId = (int)id
            };
            await _crudService.CreateAsync(blogComment);
            return RedirectToAction(nameof(SingleBlog), new { id });
        }
    }
}
