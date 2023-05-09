using Microsoft.AspNetCore.Mvc;
using ProniaApp.Areas.Admin.ViewModels.Advert;
using ProniaApp.Areas.Admin.ViewModels.Category;
using ProniaApp.Areas.Admin.ViewModels.Slider;
using ProniaApp.Helpers;
using ProniaApp.Models;
using ProniaApp.Services;
using ProniaApp.Services.Interfaces;

namespace ProniaApp.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoryController : Controller
    {
        private readonly ICategoryService _categoryService;
        private readonly ICrudService<Category> _crudService;
        public CategoryController(ICategoryService categoryService, ICrudService<Category> crudService)
        {
            _categoryService = categoryService;
            _crudService = crudService;

        }
        public async Task<IActionResult> Index()
        {
            return View(await _categoryService.GetAllAsync());
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CategoryVM model)
        {
            try
            {
                if (!ModelState.IsValid) return View();


                if (_categoryService.CheckByName(model.Name))
                {
                    ModelState.AddModelError("Name", "Name already exist");
                    return View(model);
                }

                Category category = new()
                {
                    Name = model.Name
                };

                await _crudService.CreateAsync(category);
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
            Category dbCategory = await _categoryService.GetByIdAsync((int)id);
            if (dbCategory is null) return NotFound();
            CategoryVM category = new()
            {
                Id= dbCategory.Id,
                Name = dbCategory.Name,
            };
            return View(category);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int? id, CategoryVM model)
        {
            try
            {
                if (!ModelState.IsValid) return View();

                if (id is null) return BadRequest();

                Category dbCategory = await _categoryService.GetByIdAsync((int)id);

                if (dbCategory is null) return NotFound();

                if (dbCategory.Name.Trim().ToLower() == model.Name.Trim().ToLower())
                {
                    return RedirectToAction(nameof(Index));
                }

                Category category = new()
                {
                    Id = model.Id,
                    Name = model.Name
                };

                 _crudService.Edit(category);
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

                Category dbCategory = await _categoryService.GetByIdAsync((int)id);

                if (dbCategory is null) return NotFound();

                _crudService.Delete(dbCategory);

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
