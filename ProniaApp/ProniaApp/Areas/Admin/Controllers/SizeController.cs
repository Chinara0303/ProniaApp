using Microsoft.AspNetCore.Mvc;
using ProniaApp.Areas.Admin.ViewModels.Category;
using ProniaApp.Areas.Admin.ViewModels.Size;
using ProniaApp.Models;
using ProniaApp.Services.Interfaces;

namespace ProniaApp.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class SizeController : Controller
    {
        private readonly ISizeService _sizeService;
        private readonly ICrudService<Size> _crudService;
        public SizeController(ISizeService sizeService, ICrudService<Size> crudService)
        {
            _sizeService = sizeService;
            _crudService = crudService;

        }
        public async Task<IActionResult> Index()
        {
            return View(await _sizeService.GetAllAsync());
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(SizeVM model)
        {
            try
            {
                if (!ModelState.IsValid) return View();

                Size size = new()
                {
                    Name = model.Name
                };

                await _crudService.CreateAsync(size);
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
                Size dbSize = await _sizeService.GetByIdAsync((int)id);
                if (dbSize is null) return NotFound();

                SizeVM size = new()
                {
                    Id = dbSize.Id,
                    Name = dbSize.Name,
                };
                return View(size);
            }
            catch (Exception ex)
            {
                ViewBag.error = ex.Message;
                return View();
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int? id, SizeVM model)
        {
            try
            {
                if (!ModelState.IsValid) return View();

                if (id is null) return BadRequest();

                Size dbSize = await _sizeService.GetByIdAsync((int)id);

                if (dbSize is null) return NotFound();

                if (dbSize.Name.Trim().ToLower() == model.Name.Trim().ToLower())
                {
                    return RedirectToAction(nameof(Index));
                }

                Size size = new()
                {
                    Id = model.Id,
                    Name = model.Name
                };

                _crudService.Edit(size);
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

                Size dbSize = await _sizeService.GetByIdAsync((int)id);

                if (dbSize is null) return NotFound();

                _crudService.Delete(dbSize);

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
