using Microsoft.AspNetCore.Mvc;
using ProniaApp.Services.Interfaces;
using ProniaApp.ViewModels.About;

namespace ProniaApp.Controllers
{
    public class AboutController : Controller
    {
        private readonly IAdvertService _advertService;
        private readonly IBrandService _brandService;

        public AboutController(IAdvertService advertService, IBrandService brandService)
        {
            _advertService = advertService;
            _brandService = brandService;

        }
        public async Task<IActionResult> Index()
        {
            AboutVM model = new()
            {
                Adverts = await _advertService.GetAllAsync(),
                Brands = await _brandService.GetAllAsync()
            };
            return View(model);
        }
    }
}
