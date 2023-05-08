using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProniaApp.Areas.Admin.ViewModels.Brand;
using ProniaApp.Areas.Admin.ViewModels.Slider;
using ProniaApp.Data;
using ProniaApp.Helpers;
using ProniaApp.Models;
using ProniaApp.Services;
using ProniaApp.Services.Interfaces;

namespace ProniaApp.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class BrandController : Controller
    {
        private readonly IWebHostEnvironment _env;
        private readonly ICrudService<Brand> _crudService;
        private readonly IBrandService _brandService;

        public BrandController(IWebHostEnvironment env,
                               ICrudService<Brand> crudService,
                               IBrandService brandService)
        {
            _crudService = crudService;
            _env = env;
            _brandService = brandService;
        }
        public async Task<IActionResult> Index()
        {
            return View(await _brandService.GetAllAsync());
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(BrandCreateVM model)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return View();
                }
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
                foreach (var photo in model.Photos)
                {
                    Brand newBrand = new()
                    {
                        Image = photo.CreateFile(_env, "assets/images/website-images")
                    };
                   await _crudService.CreateAsync(newBrand);
                }
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
            if (id is null) return BadRequest();
            Brand dbBrand = await _brandService.GetByIdAsync((int)id);
            if (dbBrand is null) return NotFound();
            BrandUpdateVM model = new()
            {
                Image = dbBrand.Image
            };
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int? id, BrandUpdateVM model)
        {
            try
            {
                if (id is null) return BadRequest();
                Brand dbBrand = await _brandService.GetByIdAsync((int)id);
                if (dbBrand is null) return NotFound();

                if (model.Photo == null) return RedirectToAction(nameof(Index));

                if (!model.Photo.CheckFileType("image/"))
                {
                    ModelState.AddModelError("Photo", "File type must be image");
                    return View(dbBrand);
                }
                if (!model.Photo.CheckFileSize(200))
                {
                    ModelState.AddModelError("Photo", "Image size must be max 200kb");
                    return View(dbBrand);
                }

                string oldPath = FileHelper.GetFilePath(_env.WebRootPath, "assets/images/website-images", dbBrand.Image);
                FileHelper.DeleteFile(oldPath);

                dbBrand.Image = model.Photo.CreateFile(_env, "assets/images/website-images");

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
                Brand dbBrand = await _brandService.GetByIdAsync((int)id);
                if (dbBrand is null) return NotFound();

                _crudService.Delete(dbBrand);

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
