using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using ProniaApp.Areas.Admin.ViewModels.Category;
using ProniaApp.Helpers;
using ProniaApp.Models;
using ProniaApp.Services.Interfaces;
using ProniaApp.ViewModels.Cart;
using ProniaApp.ViewModels.Product;
using ProniaApp.ViewModels.Shop;

namespace ProniaApp.Controllers
{
    public class ShopController : Controller
    {
        private readonly IProductService _productService;
        private readonly ICartService _cartService;
        private readonly ICategoryService _categoryService;
        private readonly IColorService _colorService;
        private readonly ITagService _tagService;
        private readonly IAdvertService _advertService;
        private readonly ICrudService<ProductComment> _crudService;
        private readonly ILayoutService _layoutService;
        public ShopController(IProductService productService,
                              ICategoryService categoryService,
                              ITagService tagService,
                              IColorService colorService,
                              IAdvertService advertService,
                              ILayoutService layoutService,
                              ICrudService<ProductComment> crudService,
                              ICartService cartService)
        {
            _productService = productService;
            _categoryService = categoryService;
            _tagService = tagService;
            _colorService = colorService;
            _advertService = advertService;
            _layoutService = layoutService;
            _crudService = crudService;
            _cartService = cartService;
        }

        public async Task<IActionResult> Index(int page = 1, int take = 6, int? categoryId = null, int? colorId = null, int? tagId = null)
        {
            List<Product> datas = await _productService.GetPaginatedDatasAsync(page, take, categoryId, colorId, tagId);
            List<ProductVM> mappedDatas = GetDatas(datas);
            int pageCount = 0;
            ViewBag.catId = categoryId;
            ViewBag.tagId = tagId;

            if (categoryId != null)
            {
                pageCount = await GetPageCountAsync(take, categoryId, null, null);
            }
            if (colorId != null)
            {
                pageCount = await GetPageCountAsync(take, null, colorId, null);
            }

            if (tagId != null)
            {
                pageCount = await GetPageCountAsync(take, null, null, tagId);
            }

            if (categoryId == null && tagId == null && colorId == null)
            {
                pageCount = await GetPageCountAsync(take, null, null, null);
            }

            Paginate<ProductVM> paginatedDatas = new(mappedDatas, page, pageCount);

            ShopVM model = new()
            {
                Products = await _productService.GetFullDataAsync(),
                Categories = await _categoryService.GetAllAsync(),
                Tags = await _tagService.GetAllAsync(),
                Colors = await _colorService.GetAllAsync(),
                PaginateDatas = paginatedDatas
            };
            return View(model);
        }

        private async Task<int> GetPageCountAsync(int take, int? catId, int? colorId, int? tagId)
        {
            int prodCount = 0;
            if (catId is not null)
            {
                prodCount = await _productService.GetProductsCountByCategoryAsync(catId);
            }
            if (colorId is not null)
            {
                prodCount = await _productService.GetProductsCountByColorAsync(colorId);

            }
            if (tagId is not null)
            {
                prodCount = await _productService.GetProductsCountByTagAsync(tagId);

            }
            if (catId == null && tagId == null && colorId == null)
            {
                prodCount = await _productService.GetCountAsync();
            }

            return (int)Math.Ceiling((decimal)prodCount / take);
        }

        private List<ProductVM> GetDatas(List<Product> products)
        {
            List<ProductVM> mappedDatas = new();
            foreach (var product in products)
            {
                ProductVM productList = new()
                {
                    Id = product.Id,
                    Name = product.Name,
                    Price = product.Price,
                    ProductImages = product.ProductImages,
                    Rating = product.Rating
                };
                mappedDatas.Add(productList);
            }
            return mappedDatas;
        }
        [HttpGet]
        public async Task<IActionResult> GetProductsByCategory(int? id, int page = 1, int take = 6)
        {
            if (id is null) return BadRequest();
            ViewBag.catId = id;

            var products = await _productService.GetProductsByCategoryIdAsync(id, page, take);

            int pageCount = await GetPageCountAsync(take, (int)id, null, null);

            Paginate<ProductVM> model = new(products, page, pageCount);

            return PartialView("_ProductListPartial", model);
        }

        [HttpGet]
        public async Task<IActionResult> GetProductsByColor(int? id, int page = 1, int take = 6)
        {
            if (id is null) return BadRequest();
            ViewBag.colorId = id;
            var products = await _productService.GetProductsByColorIdAsync(id);
            int pageCount = await GetPageCountAsync(take, null, (int)id, null);

            Paginate<ProductVM> model = new(products, page, pageCount);

            return PartialView("_ProductListPartial", model);
        }

        [HttpGet]
        public async Task<IActionResult> GetProductsByTag(int? id, int page = 1, int take = 6)
        {
            if (id is null) return BadRequest();
            ViewBag.tagId = id;

            var products = await _productService.GetProductsByTagIdAsync(id);

            int pageCount = await GetPageCountAsync(take, null, null, (int)id);

            Paginate<ProductVM> model = new(products, page, pageCount);

            return PartialView("_ProductListPartial", model);
        }

        [HttpGet]
        public async Task<IActionResult> GetProducts()
        {
            var products = await _productService.GetDatasAsync();
            return PartialView("_ProductListPartial", products);
        }

        [HttpGet]
        public async Task<IActionResult> SingleProduct(int? id)
        {
            try
            {
                if (id is null) return BadRequest();
                var dbProduct = await _productService.GetFullDataByIdAsync((int)id);
                if (dbProduct is null) return NotFound();

                SingleProductVM model = new()
                {
                    Id = dbProduct.Id,
                    ProductName = dbProduct.Name,
                    Price = dbProduct.Price,
                    ProductCategories = dbProduct.ProductCategories,
                    ProductTags = dbProduct.ProductTags,
                    ProductImages = dbProduct.ProductImages,
                    ProductSizes = dbProduct.ProductSizes,
                    SKU = dbProduct.SKU,
                    Rating = dbProduct.Rating,
                    Description = dbProduct.Description,
                    ColorName = dbProduct.Color.Name,
                    Adverts = await _advertService.GetAllAsync(),
                    SectionBgs = _layoutService.GetSectionBackgroundImages(),
                    RelatedProducts = await _productService.GetRelatedProducts(),
                    ProductCommentVM = new(),
                    ProductComments = dbProduct.ProductComments
                };

                return View(model);
            }
            catch (Exception ex)
            {
                ViewBag.error = ex.Message;
                return View();
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public async Task<IActionResult> PostComment(SingleProductVM model, int? id, string userId)
        {
            if (id is null || userId == null) return BadRequest();
            if (!ModelState.IsValid) return RedirectToAction(nameof(SingleProduct), new { id });

            ProductComment productComment = new()
            {
                Name = model.ProductCommentVM.Name,
                Email = model.ProductCommentVM.Email,
                Subject = model.ProductCommentVM.Subject,
                Message = model.ProductCommentVM.Message,
                AppUserId = userId,
                ProductId = (int)id
            };
            await _crudService.CreateAsync(productComment);
            return RedirectToAction(nameof(SingleProduct), new { id });
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

        [HttpPost]
        public async Task<IActionResult> AddToCart(int? id)
        {
            if (id is null) return BadRequest();

            Product dbProduct = await _productService.GetByIdAsync((int)id);

            if (dbProduct == null) return NotFound();

            List<CartVM> carts = _cartService.GetDatasFromCookie();

            CartVM existProduct = carts.FirstOrDefault(p => p.ProductId == id);

            _cartService.SetDatasToCookie(carts, dbProduct, existProduct);

            List<CartDetailVM> cartDetailVMs = new();
            int count = 0;
            foreach (var item in carts)
            {
                if(existProduct is not null)
                {
                    count = existProduct.Count;

                }
                else
                {
                    count = item.Count;
                }
            }
            CartDetailVM model = new()
            {
                Id = dbProduct.Id,
                Name = dbProduct.Name,
                Image = dbProduct.ProductImages.Where(pi => pi.IsMain).FirstOrDefault().ImgName,
                Count = count,
                Price = dbProduct.Price,
                Total = dbProduct.Price * count,
            };

            cartDetailVMs.Add(model);

            return PartialView("_CartDetailPartial", cartDetailVMs);

        }

        public async Task<IActionResult> Search(string searchText)
        {
            if (string.IsNullOrEmpty(searchText))
            {
                return Ok();
            }
            var products = await _productService.GetAllBySearchText(searchText);

            return View(products);
        }

    }
}
