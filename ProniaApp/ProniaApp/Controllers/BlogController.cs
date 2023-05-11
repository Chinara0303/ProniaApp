using Microsoft.AspNetCore.Mvc;
using ProniaApp.Services.Interfaces;
using ProniaApp.ViewModels.Blog;

namespace ProniaApp.Controllers
{
    public class BlogController : Controller
    {
        private readonly IBlogService _blogService;
        public BlogController(IBlogService blogService)
        {
            _blogService = blogService;
        }
        public async Task<IActionResult> Index()
        {
            var blogs = await _blogService.GetAllAsync();
            BlogVM model = new()
            {
                Blogs = blogs.ToList()
            };
            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> SingleBlog(int? id)
        {
            if (id is null) return BadRequest();
            var dbBlog = await _blogService.GetByIdAsync((int)id);
            BlogVM model = new()
            {
                Blog = dbBlog

            };
            return View(model);
        }
    }
}
