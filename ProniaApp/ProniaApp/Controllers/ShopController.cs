﻿using Microsoft.AspNetCore.Mvc;
using ProniaApp.Helpers;
using ProniaApp.Models;
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

        public async Task<IActionResult> Index(int page = 1,int take = 2, int? categoryId=null,int? colorId=null,int? tagId=null)
        {
            
            List<Product> datas = await _productService.GetPaginatedDatasAsync(page, take,categoryId,colorId,tagId);
            List<ProductVM> mappedDatas = GetDatas(datas);
            int pageCount = 0;

            if(categoryId != null)
            {
                 pageCount = await GetPageCountAsync(take,categoryId,null,null);
            }
            if(colorId != null)
            {
                pageCount = await GetPageCountAsync(take,null, colorId, null);

            }
            if (tagId != null)
            {
                pageCount = await GetPageCountAsync(take, null, null, tagId);
            }
            if(categoryId == null && tagId==null && colorId == null)
            {
                pageCount = await GetPageCountAsync(take,null,null,null);
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


        private async Task<int> GetPageCountAsync(int take,int? catId,int? colorId,int? tagId)
        {
            int prodCount = 0;
            if (catId is not null)
            {
                 prodCount = await _productService.GetProductsCountByCategoryAsync(catId);

            }
            if(colorId is not null)
            {
                prodCount = await _productService.GetProductsCountByColorAsync(catId);

            }
            if (tagId is not null)
            {
                prodCount = await _productService.GetProductsCountByTagAsync(catId);

            }
            else
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
        public async Task<IActionResult> GetProductsByCategory(int? id,int page=1, int take=2)
        {
            if (id is null) return BadRequest();
            ViewBag.catId = id;

            var products = await _productService.GetProductsByCategoryIdAsync(id,page,take);

            int pageCount =await GetPageCountAsync(take, (int)id, null, null);

            Paginate<ProductVM> model = new(products, page, pageCount);
          
            return PartialView("_ProductListPartial", model);
        }

        [HttpGet]
        public async Task<IActionResult> GetProductsByColor(int? id,int page = 1, int take = 2)
        {
            if (id is null) return BadRequest();
            ViewBag.colorId = id;
            var products = await _productService.GetProductsByColorIdAsync(id);
            int pageCount = await GetPageCountAsync(take, null, (int)id, null);

            Paginate<ProductVM> model = new(products, page, pageCount);

            return PartialView("_ProductListPartial", model);
        }

        [HttpGet]
        public async Task<IActionResult> GetProductsByTag(int? id, int page = 1, int take = 2)
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
