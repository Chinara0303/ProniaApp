using Microsoft.AspNetCore.Mvc;
using ProniaApp.Areas.Admin.ViewModels.Banner;
using ProniaApp.Areas.Admin.ViewModels.Slider;
using ProniaApp.Helpers;
using ProniaApp.Models;
using ProniaApp.Services;
using ProniaApp.Services.Interfaces;

namespace ProniaApp.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class BannerController : Controller
    {
        private readonly IWebHostEnvironment _env;
        private readonly IBannerService _bannerService;
        private readonly ICrudService<Banner> _crudService;
        public BannerController(IWebHostEnvironment env,
                                IBannerService bannerService,
                                ICrudService<Banner> crudService)
        {
            _env = env;
            _bannerService = bannerService;
            _crudService = crudService;
        }
        public async Task<IActionResult> Index()
        {
            IEnumerable<Banner> dbBanner = await _bannerService.GetAllAsync();
            return View(dbBanner);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(BannerCreateVM model)
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

                Banner banner = new()
                {
                    Image = model.Photo.CreateFile(_env, "assets/images/website-images"),
                    Title = model.Title,
                    SubTitle = model.SubTitle,
                    IsLarge = model.IsLarge
                };

                await _crudService.CreateAsync(banner);
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
                Banner dbBanner = await _bannerService.GetByIdAsync((int)id);
                if (dbBanner is null) return NotFound();

                BannerUpdateVM model = new()
                {
                    Image = dbBanner.Image,
                    Title = dbBanner.Title,
                    SubTitle = dbBanner.SubTitle,
                    IsLarge = dbBanner.IsLarge
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
        public async Task<IActionResult> Edit(int? id, BannerUpdateVM model)
        {
            try
            {
                if (id is null) return BadRequest();
                Banner dbBanner = await _bannerService.GetByIdAsync((int)id);
                if (dbBanner is null) return NotFound();

                BannerUpdateVM bannerUpdateVM = new()
                {
                    Image = dbBanner.Image
                };

                if (!ModelState.IsValid) return View(bannerUpdateVM);

                if (model.Photo is not null)
                {
                    if (!model.Photo.CheckFileType("image/"))
                    {
                        ModelState.AddModelError("Photo", "File type must be image");
                        return View(bannerUpdateVM);
                    }
                    if (!model.Photo.CheckFileSize(200))
                    {
                        ModelState.AddModelError("Photo", "Image size must be max 200kb");
                        return View(    );
                    }
                    string path = FileHelper.GetFilePath(_env.WebRootPath, "assets/images/website-images", bannerUpdateVM.Image);
                    FileHelper.DeleteFile(path);

                    dbBanner.Image = model.Photo.CreateFile(_env, "assets/images/website-images");
                }
                else
                {
                    Banner newBanner = new()
                    {
                        Image = dbBanner.Image
                    };
                }

                dbBanner.Title = model.Title;
                dbBanner.SubTitle = model.SubTitle;
                dbBanner.IsLarge = model.IsLarge;
                await _crudService.SaveAsync();
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                ViewBag.error = ex.Message;
                return View();
            }
        }
        public async Task<IActionResult> Delete(int? id)
        {
            try
            {
                if (id is null) return BadRequest();
                Banner dbBanner = await _bannerService.GetByIdAsync((int)id);
                if (dbBanner is null) return NotFound();

                string path = FileHelper.GetFilePath(_env.WebRootPath, "assets/images/website-images", dbBanner.Image);
                FileHelper.DeleteFile(path);

                _crudService.Delete(dbBanner);
                return Ok();
            }
            catch (Exception ex)
            {
                ViewBag.error = ex.Message;
                return View();
            }
        }

    }


}
