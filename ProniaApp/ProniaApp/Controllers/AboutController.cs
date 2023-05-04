using Microsoft.AspNetCore.Mvc;

namespace ProniaApp.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
