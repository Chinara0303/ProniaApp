using Microsoft.AspNetCore.Mvc;

namespace ProniaApp.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
