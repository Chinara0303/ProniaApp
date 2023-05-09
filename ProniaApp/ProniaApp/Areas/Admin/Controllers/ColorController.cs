using Microsoft.AspNetCore.Mvc;
using ProniaApp.Areas.Admin.ViewModels.Color;
using ProniaApp.Areas.Admin.ViewModels.Size;
using ProniaApp.Models;
using ProniaApp.Services;
using ProniaApp.Services.Interfaces;

namespace ProniaApp.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ColorController : Controller
    {
        private readonly IColorService _colorService;
        private readonly ICrudService<Color> _crudService;
        public ColorController(IColorService colorService, ICrudService<Color> crudService)
        {
            _colorService = colorService;
            _crudService = crudService;

        }
        public async Task<IActionResult> Index()
        {
            return View(await _colorService.GetAllAsync());
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(ColorVM model)
        {
            try
            {
                if (!ModelState.IsValid) return View();

                if (_colorService.CheckByName(model.Name))
                {
                    ModelState.AddModelError("Name", "Name already exist");
                    return View(model);
                }

                Color color = new()
                {
                    Name = model.Name
                };

                await _crudService.CreateAsync(color);
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
            Color dbColor = await _colorService.GetByIdAsync((int)id);
            if (dbColor is null) return NotFound();

            ColorVM color = new()
            {
                Id = dbColor.Id,
                Name = dbColor.Name,
            };
            return View(color);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int? id, ColorVM model)
        {
            try
            {
                if (!ModelState.IsValid) return View();

                if (id is null) return BadRequest();

                Color dbColor = await _colorService.GetByIdAsync((int)id);

                if (dbColor is null) return NotFound();

                if (dbColor.Name.Trim().ToLower() == model.Name.Trim().ToLower())
                {
                    return RedirectToAction(nameof(Index));
                }

                Color color = new()
                {
                    Id = model.Id,
                    Name = model.Name
                };

                _crudService.Edit(color);
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

                Color dbColor = await _colorService.GetByIdAsync((int)id);

                if (dbColor is null) return NotFound();

                _crudService.Delete(dbColor);

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
