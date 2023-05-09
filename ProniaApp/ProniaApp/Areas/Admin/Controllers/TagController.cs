using Microsoft.AspNetCore.Mvc;
using ProniaApp.Areas.Admin.ViewModels.Category;
using ProniaApp.Areas.Admin.ViewModels.Tag;
using ProniaApp.Models;
using ProniaApp.Services;
using ProniaApp.Services.Interfaces;

namespace ProniaApp.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class TagController : Controller
    {
        private readonly ITagService _tagService;
        private readonly ICrudService<Tag> _crudService;
        public TagController(ITagService tagService,
                             ICrudService<Tag> crudService)
        {
            _tagService = tagService;
            _crudService = crudService;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _tagService.GetAllAsync());
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(TagVM model)
        {
            try
            {
                if (!ModelState.IsValid) return View();

                if (_tagService.CheckByName(model.Name))
                {
                    ModelState.AddModelError("Name", "Name already exist");
                    return View(model);
                }

                Tag tag = new() { Name = model.Name };

                await _crudService.CreateAsync(tag);
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
            Tag dbTag = await _tagService.GetByIdAsync((int)id);
            if (dbTag is null) return NotFound();

            TagVM tag = new()
            {
                Id = dbTag.Id,
                Name = dbTag.Name,
            };
            return View(tag);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int? id, CategoryVM model)
        {
            try
            {
                if (!ModelState.IsValid) return View();

                if (id is null) return BadRequest();

                Tag dbTag = await _tagService.GetByIdAsync((int)id);

                if (dbTag is null) return NotFound();

                if (dbTag.Name.Trim().ToLower() == model.Name.Trim().ToLower())
                {
                    return RedirectToAction(nameof(Index));
                }

                Tag tag = new()
                {
                    Id = model.Id,
                    Name = model.Name
                };

                _crudService.Edit(tag);
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

                Tag dbTag = await _tagService.GetByIdAsync((int)id);

                if (dbTag is null) return NotFound();

                _crudService.Delete(dbTag);

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
