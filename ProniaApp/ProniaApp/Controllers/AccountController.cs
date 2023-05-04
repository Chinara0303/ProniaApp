using Microsoft.AspNetCore.Mvc;

namespace ProniaApp.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
