using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProniaApp.Areas.Admin.ViewModels.Blog;
using ProniaApp.Helpers;
using ProniaApp.Models;
using ProniaApp.Services.Interfaces;

namespace ProniaApp.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class BlogController : Controller
    {
        private readonly IWebHostEnvironment _env;
        private readonly IBlogService _blogService;
        private readonly ICrudService<Blog> _crudService;
        public BlogController(IBlogService blogService,
                                ICrudService<Blog> crudService,
                                IWebHostEnvironment env)
        {
            _blogService = blogService;
            _crudService = crudService;
            _env = env;
        }
        public async Task<IActionResult> Index()
        {
            return View(await _blogService.GetAllAsync());
        }

        [HttpGet]
        public IActionResult Create() { return View(); }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(BlogCreateVM model)
        {
            try
            {
                if (!ModelState.IsValid) return View();

                foreach (var photo in model.Photos)
                {
                    if (!photo.CheckFileType("image/"))
                    {
                        ModelState.AddModelError("Photos", "File type must be image");
                        return View();
                    }
                    if (!photo.CheckFileSize(200))
                    {
                        ModelState.AddModelError("Photos", "Image size must be max 200kb");
                        return View();
                    }
                }
                List<BlogImage> blogImages = new();

                foreach (var photo in model.Photos)
                {
                    BlogImage blogImage = new()
                    {
                        ImgName = photo.CreateFile(_env, "assets/images/website-images")
                    };
                    blogImages.Add(blogImage);
                }

                blogImages.FirstOrDefault().IsMain = true;


                Blog newBlog = new()
                {
                    Title = model.Title,
                    Description = model.Description,
                    BlogImages = blogImages,
                };

                //await  _crudService.AddRangeAsync(blogImages);
                await _crudService.CreateAsync(newBlog);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
