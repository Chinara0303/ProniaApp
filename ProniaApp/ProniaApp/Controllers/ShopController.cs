using Microsoft.AspNetCore.Mvc;

namespace ProniaApp.Controllers
{
    public class ShopController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
