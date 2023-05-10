using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProniaApp.Areas.Admin.ViewModels.Blog;
using ProniaApp.Helpers;
using ProniaApp.Models;
using ProniaApp.Services;
using ProniaApp.Services.Interfaces;
using System.Linq;

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

                _blogService.AddRangeToBlog(blogImages);
                await _crudService.CreateAsync(newBlog);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                ViewBag.error = ex.Message;
                return View();
            }
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int? id)
        {
            try
            {
                if (id is null) return BadRequest();
                Blog dbBlog = await _blogService.GetByIdAsync((int)id);
                if (dbBlog is null) return NotFound();
                BlogUpdateVM model = new()
                {
                    Id = dbBlog.Id,
                    Title = dbBlog.Title,
                    Description = dbBlog.Description,
                    Images = dbBlog.BlogImages,
                };
                return View(model);
            }
            catch (Exception ex)
            {
                ViewBag.error = ex.Message;
                return View();
            }

        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int? id,BlogUpdateVM model)
        {
            try
            {
                if (id is null) return BadRequest();
                Blog dbBlog = await _blogService.GetByIdTrackAsync((int)id);
                if (dbBlog is null) return NotFound();

                if(!ModelState.IsValid)
                {
                    model.Images = dbBlog.BlogImages;
                    return View(model);
                }
                List<BlogImage> blogImages = new();

                if (model.Photos is not null)
                {
                    int canUploadImage = 4 - dbBlog.BlogImages.Count;

                    if (model.Photos.Count() > canUploadImage)
                    {
                        ModelState.AddModelError("Photos", $"The maximum number of images you can upload is {canUploadImage}");
                        model.Images = dbBlog.BlogImages;
                        return View(model);
                    }
                    foreach (var photo in model.Photos)
                    {

                        if (!photo.CheckFileType("image/"))
                        {
                            ModelState.AddModelError("Photos", "File type must be image");
                            model.Images = dbBlog.BlogImages;
                            return View(model);
                        }
                        if (!photo.CheckFileSize(200))
                        {
                            ModelState.AddModelError("Photos", "Image size must be max 200kb");
                            model.Images = dbBlog.BlogImages;
                            return View(model);
                        }
                    }
                    foreach (var photo in model.Photos)
                    {
                        BlogImage blogImage = new()
                        {
                            ImgName = photo.CreateFile(_env, "assets/images/website-images"),
                        };
                        blogImages.Add(blogImage);
                    }
                    _blogService.AddRangeToBlog(blogImages);

                    dbBlog.BlogImages.FirstOrDefault().IsMain = true;
                }
                Blog newBlog = new()
                {
                    Id = model.Id,
                    Title = model.Title,
                    Description = model.Description,
                    BlogImages = blogImages.Count == 0 ? dbBlog.BlogImages : blogImages,
                };
                 _crudService.Edit(newBlog);

                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                ViewBag.error = ex.Message;
                return View();
            }
        }

        public async Task<IActionResult> Detail(int? id)
        {
            try
            {
                if (id is null) return BadRequest();

                Blog dbBlog = await _blogService.GetByIdAsync((int)id);

                if (dbBlog is null) return NotFound();

                BlogDetailVM model = new()
                {
                    Id = dbBlog.Id,
                    Images = dbBlog.BlogImages,
                    Title = dbBlog.Title,
                    Description = dbBlog.Description
                };
                return View(model);
            }
            catch (Exception ex)
            {
                ViewBag.error = ex.Message;
                return View();
            }
        }
        [HttpPost]
        public async Task<IActionResult> DeleteBlogImage(int? id)
        {
            try
            {
                if (id is null) return BadRequest();
                BlogImage image = await _blogService.GetImageById((int)id);
                if (image is null) return NotFound();

                Blog dbBlog = await _blogService.GetBlogByImageId((int)id);
                if (dbBlog is null) return NotFound();

                DeleteResponse response = new();
                response.Result = false;

                if(dbBlog.BlogImages.Count > 1)
                {
                    string path = FileHelper.GetFilePath(_env.WebRootPath, "assets/images/website-images", image.ImgName);
                    FileHelper.DeleteFile(path);

                    _blogService.RemoveImage(image);

                    await _crudService.SaveAsync();

                    response.Result = true;
                }

                dbBlog.BlogImages.FirstOrDefault().IsMain = true;

                response.Id = dbBlog.BlogImages.FirstOrDefault().Id;

                await _crudService.SaveAsync();

                return Ok(response);
            }
            catch (Exception ex)
            {
                ViewBag.error = ex.Message;
                return View();
            }
        }

        [HttpPost]
        public async Task<IActionResult> SetStatus(int? id)
        {
            try
            {
                if (id == null) return BadRequest();

                BlogImage image = await _blogService.GetImageById((int)id);
                if (image is null) return NotFound();

                Blog dbBlog = await _blogService.GetBlogByImageId((int)id);
                if (dbBlog is null) return NotFound();


                if (!image.IsMain)
                {
                    image.IsMain = true;
                    await _crudService.SaveAsync();
                }


                var images = dbBlog.BlogImages.Where(m => m.Id != id).ToList();

                foreach (var item in images)
                {
                    if (item.IsMain)
                    {
                        item.IsMain = false;
                        await _crudService.SaveAsync();
                    }
                }
               
                return Ok(image.IsMain);
            }
            catch (Exception ex)
            {
                ViewBag.error = ex.Message;
                return View();
            }
        }


        [HttpPost]
        public async Task<IActionResult> Delete(int? id)
        {
            try
            {
                if (id is null) return BadRequest();

                Blog dbBlog = await _blogService.GetByIdAsync((int)id);

                if (dbBlog is null) return NotFound();

                _crudService.Delete(dbBlog);

                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                ViewBag.error = ex.Message;
                return View();
            }
        }
    }

 
}
