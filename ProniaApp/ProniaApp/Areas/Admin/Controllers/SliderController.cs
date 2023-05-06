using Microsoft.AspNetCore.Mvc;
using ProniaApp.Areas.Admin.ViewModels.Slider;
using ProniaApp.Data;
using ProniaApp.Helpers;
using ProniaApp.Models;
using ProniaApp.Services.Interfaces;

namespace ProniaApp.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class SliderController : Controller
    {
        private readonly IWebHostEnvironment _env;
        private readonly ISliderService _sliderService;
        private readonly AppDbContext _context;
        public SliderController(IWebHostEnvironment env, ISliderService sliderService,
            AppDbContext context)
        {
            _env = env;
            _sliderService = sliderService;
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var dbSlider = await _sliderService.GetAllAsync();
            return View(dbSlider);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(SliderCreateVM model)
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

                Slider slider = new()
                {
                    Image = model.Photo.CreateFile(_env, "assets/images/slider"),
                    Title = model.Title,
                    ShortDesc = model.ShortDesc,
                    Offer = model.Offer
                };

                await _context.AddAsync(slider);
                await _context.SaveChangesAsync();
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
                Slider dbSlider = await _sliderService.GetByIdAsync((int)id);
                if (dbSlider is null) return NotFound();

                SliderUpdateVM model = new()
                {
                    Image = dbSlider.Image,
                    Title = dbSlider.Title,
                    ShortDesc = dbSlider.ShortDesc,
                    Offer = dbSlider.Offer
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
        public async Task<IActionResult> Edit(int? id, SliderUpdateVM model)
        {
            try
            {
                if (id is null) return BadRequest();
                Slider dbSlider = await _sliderService.GetByIdAsync((int)id);
                if (dbSlider is null) return NotFound();

                SliderUpdateVM sliderUpdateVM = new()
                {
                    Image = dbSlider.Image
                };

                if (!ModelState.IsValid) return View(sliderUpdateVM);

                if (model.Photo is not null)
                {
                    if (!model.Photo.CheckFileType("image/"))
                    {
                        ModelState.AddModelError("Photo", "File type must be image");
                        return View(sliderUpdateVM);
                    }
                    if (!model.Photo.CheckFileSize(200))
                    {
                        ModelState.AddModelError("Photo", "Image size must be max 200kb");
                        return View(sliderUpdateVM);
                    }
                    string path = FileHelper.GetFilePath(_env.WebRootPath, "assets/images/slider", sliderUpdateVM.Image);
                    FileHelper.DeleteFile(path);

                    dbSlider.Image = model.Photo.CreateFile(_env, "assets/images/slider");
                }
                else
                {
                    Slider newSlider = new()
                    {
                        Image = dbSlider.Image
                    };
                }

                dbSlider.Title = model.Title;
                dbSlider.Offer = model.Offer;
                dbSlider.ShortDesc = model.ShortDesc;
                await _context.SaveChangesAsync();
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
                Slider dbSlider = await _sliderService.GetByIdAsync((int)id);
                if (dbSlider is null) return NotFound();

                string path = FileHelper.GetFilePath(_env.WebRootPath, "assets/images/slider", dbSlider.Image);
                FileHelper.DeleteFile(path);

                _context.Sliders.Remove(dbSlider);
                await _context.SaveChangesAsync();
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
