using Microsoft.AspNetCore.Mvc;

namespace ProniaApp.Controllers
{
    public class CartController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
