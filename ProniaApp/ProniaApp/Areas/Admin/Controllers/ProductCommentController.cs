using Microsoft.AspNetCore.Mvc;
using ProniaApp.Models;
using ProniaApp.Services.Interfaces;

namespace ProniaApp.Areas.Admin.Controllers
{
    public class ProductCommentController : Controller
    {
        private readonly IWebHostEnvironment _env;
        private readonly ICrudService<Banner> _crudService;
        public ProductCommentController(IWebHostEnvironment env,
                                ICrudService<Banner> crudService)
        {
            _env = env;
            _crudService = crudService;
        }
        public IActionResult Index()
        {

            return View();
        }
    }
}
