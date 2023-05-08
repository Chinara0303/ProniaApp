using Microsoft.AspNetCore.Mvc;
using ProniaApp.Data;
using ProniaApp.Helpers;
using ProniaApp.Models;
using ProniaApp.Services.Interfaces;

namespace ProniaApp.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class SectionBackgroundController : Controller
    {
        private readonly IWebHostEnvironment _env;
        private readonly ICrudService<SectionBackgroundImage> _crudService;
        private readonly ILayoutService _layoutService;

        public SectionBackgroundController(IWebHostEnvironment env,
                                ILayoutService layoutService,
                                ICrudService<SectionBackgroundImage> crudService)
        {
            _crudService = crudService;
            _env = env;
            _layoutService = layoutService;
        }
        public async Task<IActionResult> Index()
        {
            return View(await _layoutService.GetSectionBackgroundImageDatasAsync());
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int? id)
        {
            return View(await _layoutService.GetSectionBackgroundImageByIdAsync((int)id));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int? id, SectionBackgroundImage sectionBackground)
        {
            try
            {
                var dbSectionBg = await _layoutService.GetSectionBackgroundImageByIdAsync((int)id);

                if (dbSectionBg == null) return View();

                if (sectionBackground.Photo is not null)
                {
                    if (!sectionBackground.Photo.CheckFileType("image/"))
                    {
                        ModelState.AddModelError("Photo", "File type must be image");
                        return View();
                    }
                    if (!sectionBackground.Photo.CheckFileSize(200))
                    {
                        ModelState.AddModelError("Photo", "Image size must be max 200kb");
                        return View();
                    }
                    string path = FileHelper.GetFilePath(_env.WebRootPath, "assets/images/website-images", dbSectionBg.Value);
                    FileHelper.DeleteFile(path);

                    dbSectionBg.Value = sectionBackground.Photo.CreateFile(_env, "assets/images/website-images");
                }
                else
                {
                    SectionBackgroundImage newSectionBg = new()
                    {
                        Value = dbSectionBg.Value
                    };
                }
                await _crudService.SaveAsync();
                return RedirectToAction(nameof(Index));
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
