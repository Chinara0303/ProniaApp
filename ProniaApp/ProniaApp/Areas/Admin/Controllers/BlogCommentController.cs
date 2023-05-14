using Microsoft.AspNetCore.Mvc;
using ProniaApp.Models;
using ProniaApp.Services.Interfaces;

namespace ProniaApp.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class BlogCommentController : Controller
    {
        private readonly ICrudService<BlogComment> _crudService;
        private readonly IBlogService _blogService;
        public BlogCommentController(ICrudService<BlogComment> crudService,
                                        IBlogService blogService)
        {
            _crudService = crudService;
            _blogService = blogService;
        }
        public async Task<IActionResult> Index()
        {
            var comments = await _blogService.GetComments();
            return View(comments);
        }

        [HttpGet]
        public async Task<IActionResult> Detail(int? id)
        {
            if (id == null) return BadRequest();
            BlogComment dbcomment = await _blogService.GetCommentByIdWithBlog((int)id);
            if (dbcomment is null) return NotFound();
            return View(dbcomment);
        }

        [HttpPost]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return BadRequest();
            BlogComment dbcomment = await _blogService.GetCommentById((int)id);
            if (dbcomment is null) return NotFound();

            _crudService.Delete(dbcomment);
            return Ok();
        }
    }
}
