using Microsoft.AspNetCore.Mvc;
using ProniaApp.Services.Interfaces;
using ProniaApp.ViewModels.Home;

namespace ProniaApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProductService _productService;
        public HomeController(IProductService productService)
        {
            _productService = productService;
        }
        public async Task<IActionResult> Index()
        {
            HomeVM model = new()
            {
                Products = await _productService.GetAllAsync(),
            };
            return View(model);
        }
    }
}