using Microsoft.AspNetCore.Mvc;

namespace ProniaApp.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
