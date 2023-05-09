using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using ProniaApp.Areas.Admin.ViewModels.Product;
using ProniaApp.Data;
using ProniaApp.Helpers;
using ProniaApp.Models;
using ProniaApp.Services;
using ProniaApp.Services.Interfaces;

namespace ProniaApp.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductController : Controller
    {
        private readonly IWebHostEnvironment _env;
        private readonly IProductService _productService;
        private readonly IColorService _colorService;
        private readonly ISizeService _sizeService;
        private readonly ICategoryService _categoryService;
        private readonly ITagService _tagService;
        private readonly ICrudService<Product> _crudService;
        public ProductController(IProductService productService,
                                ICrudService<Product> crudService,
                                IWebHostEnvironment env,
                                IColorService colorService,
                                ITagService tagService,
                                ISizeService sizeService,
                                ICategoryService categoryService)
        {
            _productService = productService;
            _crudService = crudService;
            _env = env;
            _colorService = colorService;
            _tagService = tagService;
            _sizeService = sizeService;
            _categoryService = categoryService;
        }

        public async Task<IActionResult> Index(int page = 1,int take = 2)
        {
            List<Product> datas = await _productService.GetPaginatedDatasAsync(page, take);
            List<ProductListVM> mappedDatas = GetDatas(datas);

            int pageCount = await GetPageCountAsync(take);

            Paginate<ProductListVM> paginatedDatas = new(mappedDatas, page, pageCount);

            return View(paginatedDatas);
        }
        private async Task<int> GetPageCountAsync(int take)
        {
            var productCount = await _productService.GetCountAsync();
            return (int)Math.Ceiling((decimal)productCount / take);
        }
        private List<ProductListVM> GetDatas(List<Product> products)
        {
            List<ProductListVM> mappedDatas = new();
            foreach (var product in products)
            {
                ProductListVM productList = new()
                {
                    Id = product.Id,
                    Name = product.Name,
                    Price = product.Price,
                    Mainmage = product.MainImage
                };
                mappedDatas.Add(productList);
            }
            return mappedDatas;
        }
        [HttpGet]
        public async Task<IActionResult> Create()
        {
            ViewBag.colors = await GetColorsAsync();
            ViewBag.tags = await GetTagsAsync();
            ViewBag.sizes = await GetSizesAsync();
            ViewBag.categories = await GetCategoriesAsync();
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(ProductCreateVM model)
        {
            try
            {
                ViewBag.colors = await GetColorsAsync();
                ViewBag.tags = await GetTagsAsync();
                ViewBag.sizes = await GetSizesAsync();
                ViewBag.categories = await GetCategoriesAsync();

                if (!ModelState.IsValid) return View(model);

                Product newProduct = new();
                List<ProductImage> productImages = new();
                List<ProductTag> productTags = new();
                List<ProductSize> productSizes = new();
                List<ProductCategory> productCategories = new();

                int canUploadImg = 5 -  model.Photos.Count;

                if (model.Photos.Count() > canUploadImg)
                {
                    ModelState.AddModelError("Photos", $"The maximum number of images you can upload is {canUploadImg}");
                    return View();
                }

                foreach (var photo in model.Photos)
                {
                    if (!photo.CheckFileType("image/"))
                    {
                        ModelState.AddModelError("Photos", "File type must be image");
                        return View();
                    }
                    if (!photo.CheckFileSize(200))
                    {
                        ModelState.AddModelError("Photos", "Image size must be max 200kb");
                        return View();
                    }
                }

                foreach (var photo in model.Photos)
                {
                    ProductImage productImage = new()
                    {
                        ImgName = photo.CreateFile(_env, "assets/images/website-images")
                    };
                    productImages.Add(productImage);
                }
                newProduct.ProductImages = productImages;

                if (!model.MainPhoto.CheckFileType("image/"))
                {
                    ModelState.AddModelError("MainPhoto", "File type must be image");
                    return View();
                }
                if (!model.MainPhoto.CheckFileSize(200))
                {
                    ModelState.AddModelError("MainPhoto", "Image size must be max 200kb");
                    return View();
                }

                newProduct.MainImage = model.MainPhoto.CreateFile(_env, "assets/images/website-images");

                if (!model.HoverPhoto.CheckFileType("image/"))
                {
                    ModelState.AddModelError("HoverPhoto", "File type must be image");
                    return View();
                }
                if (!model.MainPhoto.CheckFileSize(200))
                {
                    ModelState.AddModelError("HoverPhoto", "Image size must be max 200kb");
                    return View();
                }
                newProduct.HoverImage = model.HoverPhoto.CreateFile(_env, "assets/images/website-images");


                if (model.TagIds.Count > 0)
                {
                    foreach (var item in model.TagIds)
                    {
                        ProductTag productTag = new()
                        {
                            TagId = item
                        };
                        productTags.Add(productTag);
                    }
                    newProduct.ProductTags = productTags;
                }
                else
                {
                    ModelState.AddModelError("TagIds", "Don`t be empty");
                    return View();
                }

                if (model.SizeIds.Count > 0)
                {
                    foreach (var item in model.SizeIds)
                    {
                        ProductSize productSize = new()
                        {
                            SizeId = item
                        };
                        productSizes.Add(productSize);
                    }
                    newProduct.ProductSizes = productSizes;
                }
                else
                {
                    ModelState.AddModelError("SizeIds", "Don`t be empty");
                    return View();
                }

                if (model.CategoryIds.Count > 0)
                {
                    foreach (var item in model.CategoryIds)
                    {
                        ProductCategory productCategory = new()
                        {
                            CategoryId = item
                        };
                        productCategories.Add(productCategory);
                    }
                    newProduct.ProductCategories = productCategories;
                }
                else
                {
                    ModelState.AddModelError("CategoryIds", "Don`t be empty");
                    return View();
                }

                var convertedPrice = decimal.Parse(model.Price);
                Random random = new();

                newProduct.Name = model.Name;
                newProduct.Description = model.Description;
                newProduct.Price = convertedPrice;
                newProduct.StockCount = model.StockCount;
                newProduct.SKU = model.Name + "-" + random.Next();
                newProduct.ColorId = model.ColorId;

                await _crudService.CreateAsync(newProduct);
                await _crudService.SaveAsync();

                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                ViewBag.error = ex.Message;
                return View();
            }
        }

        [HttpGet]
        public async Task<IActionResult> Detail(int? id)
        {
            try
            {
                if (id is null) return BadRequest();
                Product dbProduct = await _productService.GetFullDataByIdAsync((int)id);
                if (dbProduct is null) return NotFound();



                ProductDetailVM model = new()
                {
                    Id = dbProduct.Id,
                    Name = dbProduct.Name,
                    Description = dbProduct.Description,
                    Price = dbProduct.Price,
                    StockCount = dbProduct.StockCount,
                    SaleCount = dbProduct.SaleCount,
                    Images = dbProduct.ProductImages,
                    CategoryNames = dbProduct.ProductCategories,
                    TagNames = dbProduct.ProductTags,
                    SizeNames = dbProduct.ProductSizes,
                    ColorName = dbProduct.Color.Name,
                    HoverImage = dbProduct.HoverImage,
                    MainImage = dbProduct.MainImage,
                };
                return View(model);
            }
            catch (Exception ex)
            {
                ViewBag.error = ex.Message;
                return View();
            }
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int? id)
        {
            try
            {
                if (id is null) return BadRequest();
                Product dbProduct = await _productService.GetFullDataByIdAsync((int)id);
                if (dbProduct is null) return NotFound();

                ViewBag.colors = await GetColorsAsync();
                ViewBag.tags = await GetTagsAsync();
                ViewBag.sizes = await GetSizesAsync();
                ViewBag.categories = await GetCategoriesAsync();

                ProductUpdateVM model = new()
                {
                    Id = dbProduct.Id,
                    Name = dbProduct.Name,
                    Description = dbProduct.Description,
                    Price = dbProduct.Price,
                    SKU = dbProduct.SKU,
                    StockCount = dbProduct.StockCount,
                    ProductImages = dbProduct.ProductImages,
                    CategoryIds = dbProduct.ProductCategories.Select(c => c.Category.Id).ToList(),
                    TagIds = dbProduct.ProductTags.Select(t => t.Tag.Id).ToList(),
                    SizeIds = dbProduct.ProductSizes.Select(s => s.Size.Id).ToList(),
                    MainImage = dbProduct.MainImage,
                    HoverImage = dbProduct.HoverImage,
                    ColorId = dbProduct.ColorId
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
        public async Task<IActionResult> Edit(int? id, ProductUpdateVM model)
        {
            try
            {

                ViewBag.colors = await GetColorsAsync();
                ViewBag.tags = await GetTagsAsync();
                ViewBag.sizes = await GetSizesAsync();
                ViewBag.categories = await GetCategoriesAsync();

                if (id is null) return BadRequest();
                Product dbProduct = await _productService.GetFullDataByIdAsync((int)id);
                if (dbProduct is null) return NotFound();

                if (!ModelState.IsValid)
                {
                    model.ProductImages = dbProduct.ProductImages;
                    model.MainImage = dbProduct.MainImage;
                    model.HoverImage = dbProduct.HoverImage;
                    return View(dbProduct);
                }


                int canUploadImg = 5 - dbProduct.ProductImages.Count;
                if (model.Photos is not null)
                {
                    List<ProductImage> productImages = new();

                    if (model.Photos.Count > canUploadImg)
                    {
                        ModelState.AddModelError("Photos", $"The maximum number of images you can upload is {canUploadImg}");
                        model.ProductImages = dbProduct.ProductImages;
                        model.MainImage = dbProduct.MainImage;
                        model.HoverImage = dbProduct.HoverImage;
                        return View(model);
                    }

                    foreach (var photo in model.Photos)
                    {
                        if (!photo.CheckFileType("image/"))
                        {
                            ModelState.AddModelError("Photos", "File type must be image");
                            model.ProductImages = dbProduct.ProductImages;
                            model.MainImage = dbProduct.MainImage;
                            model.HoverImage = dbProduct.HoverImage;
                            return View(model);
                        }
                        if (!photo.CheckFileSize(200))
                        {
                            ModelState.AddModelError("Photos", "Image size must be max 200kb");
                            model.ProductImages = dbProduct.ProductImages;
                            model.MainImage = dbProduct.MainImage;
                            model.HoverImage = dbProduct.HoverImage;
                            return View(model);
                        }
                    }

                    foreach (var photo in model.Photos)
                    {
                        ProductImage productImage = new()
                        {
                            ImgName = photo.CreateFile(_env, "assets/images/website-images")
                        };
                        productImages.Add(productImage);
                    }
                    dbProduct.ProductImages = productImages;
                }
                else
                {
                    model.ProductImages = dbProduct.ProductImages;
                }

                if (model.MainPhoto is not null)
                {
                    if (!model.MainPhoto.CheckFileType("image/"))
                    {
                        ModelState.AddModelError("MainPhoto", "File type must be image");
                        model.ProductImages = dbProduct.ProductImages;
                        model.MainImage = dbProduct.MainImage;
                        model.HoverImage = dbProduct.HoverImage;
                        return View(model);
                    }
                    if (!model.MainPhoto.CheckFileSize(200))
                    {
                        ModelState.AddModelError("MainPhoto", "Image size must be max 200kb");
                        model.ProductImages = dbProduct.ProductImages;
                        model.MainImage = dbProduct.MainImage;
                        model.HoverImage = dbProduct.HoverImage;
                        return View(model);
                    }

                    dbProduct.MainImage = model.MainPhoto.CreateFile(_env, "assets/images/website-images");
                }
                else
                {
                    model.MainImage = dbProduct.MainImage;
                }

                if (model.HoverPhoto is not null)
                {

                    if (!model.HoverPhoto.CheckFileType("image/"))
                    {
                        ModelState.AddModelError("HoverPhoto", "File type must be image");
                        model.ProductImages = dbProduct.ProductImages;
                        model.MainImage = dbProduct.MainImage;
                        model.HoverImage = dbProduct.HoverImage;
                        return View(model);
                    }
                    if (!model.MainPhoto.CheckFileSize(200))
                    {
                        ModelState.AddModelError("HoverPhoto", "Image size must be max 200kb");
                        model.ProductImages = dbProduct.ProductImages;
                        model.MainImage = dbProduct.MainImage;
                        model.HoverImage = dbProduct.HoverImage;
                        return View(dbProduct);
                    }
                    dbProduct.HoverImage = model.HoverPhoto.CreateFile(_env, "assets/images/website-images");
                }
                else
                {
                    model.HoverImage = dbProduct.HoverImage;
                }

                if (model.TagIds.Count > 0)
                {
                    List<ProductTag> productTags = new();

                    foreach (var item in model.TagIds)
                    {
                        ProductTag productTag = new()
                        {
                            TagId = item
                        };
                        productTags.Add(productTag);
                    }
                    dbProduct.ProductTags = productTags;
                }

                if (model.SizeIds.Count > 0)
                {
                    List<ProductSize> productSizes = new();

                    foreach (var item in model.SizeIds)
                    {
                        ProductSize productSize = new()
                        {
                            SizeId = item
                        };
                        productSizes.Add(productSize);
                    }
                    dbProduct.ProductSizes = productSizes;
                }

                if (model.CategoryIds.Count > 0)
                {
                    List<ProductCategory> productCategories = new();

                    foreach (var item in model.CategoryIds)
                    {
                        ProductCategory productCategory = new()
                        {
                            CategoryId = item
                        };
                        productCategories.Add(productCategory);
                    }
                    dbProduct.ProductCategories = productCategories;
                }

                dbProduct.Name = model.Name;
                dbProduct.Description = model.Description;
                dbProduct.Price = model.Price;
                dbProduct.StockCount = model.StockCount;
                dbProduct.ColorId = model.ColorId;

                await _crudService.SaveAsync();

                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                ViewBag.error = ex.Message;
                return View();
            }
        }

        [HttpPost]
        public async Task<IActionResult> Delete(int? id)
        {
            try
            {
                if (id is null) return BadRequest();
                Product dbProduct = await _productService.GetByIdAsync((int)id);
                if (dbProduct is null) return NotFound();

                string MainImagePath = FileHelper.GetFilePath(_env.WebRootPath, "assets/images/website-images", dbProduct.MainImage);
                string HoverImagePath = FileHelper.GetFilePath(_env.WebRootPath, "assets/images/website-images", dbProduct.HoverImage);
                FileHelper.DeleteFile(MainImagePath);
                FileHelper.DeleteFile(HoverImagePath);
                foreach (var productImage in dbProduct.ProductImages)
                {
                    string imagePath = FileHelper.GetFilePath(_env.WebRootPath, "assets/images/website-images", productImage.ImgName);
                    FileHelper.DeleteFile(imagePath);
                }

                _crudService.Delete(dbProduct);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                ViewBag.error = ex.Message;
                return View();
            }
        }

        [HttpPost]
        public async Task<IActionResult> DeleteProductImage(int? id)
        {
            try
            {
                if (id is null) return BadRequest();
                ProductImage image = await _productService.GetImageById((int)id);

                if (image is null) return NotFound();
                Product dbProduct = await _productService.GetProductByImageId((int)id);
                if (dbProduct is null) return NotFound();

                
                string path = FileHelper.GetFilePath(_env.WebRootPath, "assets/images/website-images", image.ImgName);
                FileHelper.DeleteFile(path);

                _productService.RemoveImage(image);
                await _crudService.SaveAsync();
                return Ok();
            }
            catch (Exception ex)
            {
                ViewBag.error = ex.Message;
                return View();
            }
        }

        private async Task<SelectList> GetColorsAsync()
        {
            IEnumerable<Color> colors = await _colorService.GetAllAsync();
            return new SelectList(colors, "Id", "Name");
        }
        private async Task<SelectList> GetTagsAsync()
        {
            IEnumerable<Tag> tags = await _tagService.GetAllAsync();
            return new SelectList(tags, "Id", "Name");
        }
        private async Task<SelectList> GetSizesAsync()
        {
            IEnumerable<Size> sizes = await _sizeService.GetAllAsync();
            return new SelectList(sizes, "Id", "Name");
        }
        private async Task<SelectList> GetCategoriesAsync()
        {
            IEnumerable<Category> categories = await _categoryService.GetAllAsync();
            return new SelectList(categories, "Id", "Name");

        }


    }
}
