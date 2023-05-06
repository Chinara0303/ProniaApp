using Microsoft.AspNetCore.Mvc;
using ProniaApp.Areas.Admin.ViewModels.Slider;
using ProniaApp.Areas.Admin.ViewModels.Testimonial;
using ProniaApp.Helpers;
using ProniaApp.Models;
using ProniaApp.Services;
using ProniaApp.Services.Interfaces;

namespace ProniaApp.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class TestimonialController : Controller
    {
        private readonly IWebHostEnvironment _env;
        private readonly ITestimonialService _testimonialService;
        private readonly ICrudService<Testimonial> _crudService;
        public TestimonialController(ITestimonialService testimonialService,
                                     ICrudService<Testimonial> crudService,
                                     IWebHostEnvironment env)
        {
            _testimonialService = testimonialService;
            _crudService = crudService;
            _env = env;
        }
        public async Task<IActionResult> Index()
        {
            IEnumerable<Testimonial> dbTestimonial = await _testimonialService.GetAllAsync();
            return View(dbTestimonial);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(TestimonialCreateVM model)
        {
            try
            {
                if (!ModelState.IsValid) return View();

                if (!model.Photo.CheckFileType("image/"))
                {
                    ModelState.AddModelError("Photo", "File type must be image");
                    return View();
                }
                if (!model.Photo.CheckFileSize(200))
                {
                    ModelState.AddModelError("Photo", "Image size must be max 200kb");
                    return View();
                }

                Testimonial testimonial = new()
                {
                    Image = model.Photo.CreateFile(_env, "assets/images/website-images"),
                    Name = model.Name,
                    Profession = model.Profession,
                    Description = model.Description
                };

                await _crudService.CreateAsync(testimonial);
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
                Testimonial dbTestimonial = await _testimonialService.GetByIdAsync((int)id);
                if (dbTestimonial is null) return NotFound();

                TestimonialUpdateVM model = new()
                {
                    Image = dbTestimonial.Image,
                    Name = dbTestimonial.Name,
                    Profession = dbTestimonial.Profession,
                    Description = dbTestimonial.Description
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
        public async Task<IActionResult> Edit(int? id, TestimonialUpdateVM model)
        {
            try
            {
                if (id is null) return BadRequest();

                Testimonial dbTestimonial = await _testimonialService.GetByIdAsync((int)id);

                if (dbTestimonial is null) return NotFound();

                TestimonialUpdateVM testimonialUpdateVM = new()
                {
                    Image = dbTestimonial.Image
                };

                if (!ModelState.IsValid) return View(testimonialUpdateVM);

                if (model.Photo is not null)
                {
                    if (!model.Photo.CheckFileType("image/"))
                    {
                        ModelState.AddModelError("Photo", "File type must be image");
                        return View(testimonialUpdateVM);
                    }
                    if (!model.Photo.CheckFileSize(200))
                    {
                        ModelState.AddModelError("Photo", "Image size must be max 200kb");
                        return View(testimonialUpdateVM);
                    }
                    string path = FileHelper.GetFilePath(_env.WebRootPath, "assets/images/website-images", dbTestimonial.Image);
                    FileHelper.DeleteFile(path);

                    dbTestimonial.Image = model.Photo.CreateFile(_env, "assets/images/website-images");
                }
                else
                {
                    Testimonial newTestimonial = new()
                    {
                        Image = dbTestimonial.Image
                    };
                }

                dbTestimonial.Name = model.Name;
                dbTestimonial.Profession = model.Profession;
                dbTestimonial.Description = model.Description;

                await _crudService.SaveAsync();
                return RedirectToAction(nameof(Index));
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
                Testimonial dbTestimonial = await _testimonialService.GetByIdAsync((int)id);
                if (dbTestimonial is null) return NotFound();

                string path = FileHelper.GetFilePath(_env.WebRootPath, "assets/images/website-images", dbTestimonial.Image);
                FileHelper.DeleteFile(path);

                _crudService.Delete(dbTestimonial);
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
