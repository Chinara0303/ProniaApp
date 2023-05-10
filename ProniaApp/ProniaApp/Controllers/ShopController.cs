using Microsoft.AspNetCore.Mvc;
using ProniaApp.Services.Interfaces;
using ProniaApp.ViewModels.Shop;

namespace ProniaApp.Controllers
{
    public class ShopController : Controller
    {
        private readonly IProductService _productService;
        private readonly ICategoryService _categoryService;
        private readonly IColorService _colorService;
        private readonly ITagService _tagService;
        public ShopController(IProductService productService,
                              ICategoryService categoryService,
                              ITagService tagService,
                              IColorService colorService)
        {
            _productService = productService;
            _categoryService = categoryService;
            _tagService = tagService;
            _colorService = colorService;
        }
        public async Task<IActionResult> Index()
        {
            ShopVM model = new()
            {
                Products = await _productService.GetFullDataAsync(),
                Categories = await _categoryService.GetAllAsync(),
                Tags = await _tagService.GetAllAsync(),
                Colors = await _colorService.GetAllAsync()
            };
            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> GetProductsByCategory(int? id)
        {
            if (id is null) return BadRequest();
            var products = await _productService.GetProductsByCategoryIdAsync(id);
            return PartialView("_ProductListPartial", products);
        }

        [HttpGet]
        public async Task<IActionResult> GetProductsByColor(int? id)
        {
            if (id is null) return BadRequest();
            var products = await _productService.GetProductsByColorIdAsync(id);
            return PartialView("_ProductListPartial", products);
        }

        [HttpGet]
        public async Task<IActionResult> GetProductsByTag(int? id)
        {
            if (id is null) return BadRequest();
            var products = await _productService.GetProductsByTagIdAsync(id);
            return PartialView("_ProductListPartial", products);
        }

        [HttpGet]
        public async Task<IActionResult> GetProducts()
        {
            var products = await _productService.GetAllAsync();
            return PartialView("_ProductListPartial", products);
        }

        [HttpPost]
        public async Task<IActionResult> Filter(string value)
        {
            if (value is null) return BadRequest();
            var products = await _productService.GetAllAsync();
            switch (value)
            {
                case "Sort by Default":
                    products = products;
                    break;
                case "Sort by Popularity":
                    products = products.OrderByDescending(p => p.SaleCount);
                    break;
                case "Sort by Rated":
                    products = products.OrderByDescending(p => p.Rating);
                    break;
                case "Sort by Latest":
                    products = products.OrderByDescending(p => p.CreatedDate);
                    break;
                case "Sort by High Price":
                    products = products.OrderByDescending(p => p.Price);
                    break;
                case "Sort by Low Price":
                    products = products.OrderBy(p => p.Price);
                    break;
                default:
                    break;
            }
            return PartialView("_ProductListPartial", products);

        }
    }
}
