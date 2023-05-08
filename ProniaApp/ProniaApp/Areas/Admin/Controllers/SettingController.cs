using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using ProniaApp.Areas.Admin.ViewModels.Layout;
using ProniaApp.Data;
using ProniaApp.Helpers;
using ProniaApp.Models;
using ProniaApp.Services;
using ProniaApp.Services.Interfaces;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace ProniaApp.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class SettingController : Controller
    {
        private readonly IWebHostEnvironment _env;
        private readonly ICrudService<Slider> _crudService;
        private readonly ILayoutService _layoutService;

        public SettingController(IWebHostEnvironment env,
                                ILayoutService layoutService,
                                ICrudService<Slider> crudService)
        {
            _crudService = crudService;
            _env = env;
            _layoutService = layoutService;
        }
        public async Task<IActionResult> Index()
        {
            return View(await _layoutService.GetSettingDatas());
        }

        [HttpGet]
        public IActionResult Edit(int? id)
        {
            var dbSsetting = _layoutService.GetById((int)id);

            return View(dbSsetting);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int? id, Setting setting)
        {
            try
            {
                var dbSetting = _layoutService.GetById((int)id);

                if (dbSetting == null) return View();


                if (dbSetting.Value.Contains(".png") || dbSetting.Value.Contains(".jpg") || dbSetting.Value.Contains(".jpeg"))
                {
                    if (setting.LogoPhoto is not null)
                    {
                        if (!setting.LogoPhoto.CheckFileType("image/"))
                        {
                            ModelState.AddModelError("LogoPhoto", "File type must be image");
                            return View();
                        }
                        if (!setting.LogoPhoto.CheckFileSize(200))
                        {
                            ModelState.AddModelError("LogoPhoto", "Image size must be max 200kb");
                            return View();
                        }
                        string path = FileHelper.GetFilePath(_env.WebRootPath, "assets/images/website-images", dbSetting.Value);
                        FileHelper.DeleteFile(path);

                        dbSetting.Value = setting.LogoPhoto.CreateFile(_env, "assets/images/website-images");
                    }
                    else
                    {
                        Setting newSetting = new()
                        {
                            Value = dbSetting.Value
                        };
                    }
                }
                else
                {

                    if (dbSetting.Value.Trim().ToLower() == setting.Value.Trim().ToLower())
                    {

                        return RedirectToAction(nameof(Index));
                    }
                    dbSetting.Value = setting.Value;

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
