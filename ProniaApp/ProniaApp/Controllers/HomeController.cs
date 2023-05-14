using Microsoft.AspNetCore.Mvc;
using ProniaApp.Services.Interfaces;
using ProniaApp.ViewModels.Home;

namespace ProniaApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProductService _productService;
        private readonly ISliderService _sliderService;
        private readonly IBannerService _bannerService;
        private readonly IBrandService _brandService;
        private readonly IBlogService _blogService;
        private readonly ITestimonialService _testimonialService;
        private readonly IAdvertService _advertService;
        public HomeController(IProductService productService,
                                ISliderService sliderService,
                                IBannerService bannerService,
                                IBrandService brandService,
                                IBlogService blogService,
                                ITestimonialService testimonialService,
                                IAdvertService advertService)
        {
            _productService = productService;
            _sliderService = sliderService;
            _bannerService = bannerService;
            _brandService = brandService;
            _blogService = blogService;
            _testimonialService = testimonialService;
            _advertService = advertService;
        }
        public async Task<IActionResult> Index()
        {
            HomeVM model = new()
            {
                Products = await _productService.GetAllAsync(),
                Sliders = await _sliderService.GetAllAsync(),
                Banners  =await _bannerService.GetAllAsync(),
                Brands = await _brandService.GetAllAsync(),
                Blogs = await _blogService.GetAllAsync(),
                Testimonials = await _testimonialService.GetAllAsync(),
                Adverts  = await _advertService.GetAllAsync()
            };
            return View(model);
        }
    }
}