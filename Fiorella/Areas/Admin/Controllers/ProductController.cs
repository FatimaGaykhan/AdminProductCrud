using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Fiorella.Extensions;
using Fiorella.Helpers;
using Fiorella.Models;
using Fiorella.Services.Interfaces;
using Fiorella.ViewModels.Blog;
using Fiorella.ViewModels.Products;
using Microsoft.AspNetCore.Mvc;
using static System.Net.Mime.MediaTypeNames;


namespace Fiorella.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductController : Controller
    {


        private readonly IProductService _productService;
        private readonly ICategoryService _categoryService;
        private readonly IWebHostEnvironment _env;

        public ProductController(IProductService productService,
                                 ICategoryService categoryService,
                                 IWebHostEnvironment env)
        {
            _productService = productService;
            _categoryService = categoryService;
            _env = env;
        }


        [HttpGet]
        public async Task<IActionResult> Index(int page = 1)
        {
            var products = await _productService.GetAllPaginateAsync(page, 4);

            var mappedDatas = _productService.GetMappedDatas(products);

            int totalPage = await GetPageCountAsync(4);

            Paginate<ProductVM> paginateDatas = new(mappedDatas, totalPage, page);

            return View(paginateDatas);
        }

        private async Task<int> GetPageCountAsync(int take)
        {
            int productCount = await _productService.GetCountAsync();

            return (int)Math.Ceiling((decimal)productCount / take);
        }

        [HttpGet]
        public async Task<IActionResult> Detail(int? id)
        {
            if (id is null) return BadRequest();

            var existProduct = await _productService.GetByIdWithAllDatas((int)id);

            if (existProduct is null) return NotFound();

            List<ProductImageVM> images = new();

            foreach (var item in existProduct.ProductImages)
            {
                images.Add(new ProductImageVM
                {
                    Image = item.Name,
                    IsMain = item.IsMain
                });
            }

            ProductDetailVM response = new()
            {
                Name = existProduct.Name,
                Description = existProduct.Description,
                Price = existProduct.Price,
                Category = existProduct.Category.Name,
                Images = images
            };

            return View(response);
        }

        [HttpGet]
        public async Task<IActionResult> Create()
        {
            ViewBag.categories = await _categoryService.GetAllSelectedAsync();

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(ProductCreateVM request)
        {
            ViewBag.categories = await _categoryService.GetAllSelectedAsync();

            if (!ModelState.IsValid)
            {
                return View();
            }

            foreach (var item in request.Images)
            {
                if (!item.CheckFileSize(500))
                {
                    ModelState.AddModelError("Images", "Image size must be 500KB");
                    return View();
                }

                if (!item.CheckFileType("image/"))
                {
                    ModelState.AddModelError("Images", "File type must be only image ");
                    return View();
                }
            }

            List<ProductImage> images = new();


            foreach (var item in request.Images)
            {
                string fileName = $"{Guid.NewGuid()}-{item.FileName}";
                string path = _env.GenerateFilePath("img", fileName);
                await item.SaveFileToLocalAsync(path);

                images.Add(new ProductImage { Name = fileName });
            }

            images.FirstOrDefault().IsMain = true;

            Product product = new()
            {
                Name = request.Name,
                Description = request.Description,
                CategoryId = request.CategoryId,
                Price = decimal.Parse(request.Price.Replace(".",",")),
                ProductImages = images

            };

            await _productService.CreateAsync(product);

            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id is null) return BadRequest();

            var existProduct = await _productService.GetByIdWithAllDatas((int)id);

            if (existProduct is null) return NotFound();

            foreach (var item in existProduct.ProductImages)
            {
                string path = _env.GenerateFilePath("img", item.Name);
                path.DeleteFileFromLocal();
            }

            await _productService.DeleteAsync(existProduct);

            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id is null) return BadRequest();

            var existProduct = await _productService.GetByIdWithAllDatas((int)id);

            if (existProduct is null) return NotFound();



            ViewBag.category = existProduct.Category;
            ViewBag.categories = await _categoryService.GetAllSelectedAsync();

            List<ProductImageVM> images = new();

            foreach (var item in existProduct.ProductImages)
            {
                images.Add(new ProductImageVM
                {
                    Id=item.Id,
                    Image = item.Name,
                    IsMain = item.IsMain
                });
            }

            ProductEditVM response = new()
            {
                Name = existProduct.Name,
                Description = existProduct.Description,
                Price = existProduct.Price.ToString().Replace(",","."),
                Images = images
            };

            return View(response);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int? id, ProductEditVM request)
        {
            if (id is null) return BadRequest();


            ViewBag.categories = await _categoryService.GetAllSelectedAsync();

            var product = await _productService.GetByIdWithAllDatas((int)id);

            if (product is null) return NotFound();

            List<ProductImageVM> images = new();

            foreach (var item in product.ProductImages)
            {
                images.Add(new ProductImageVM
                {
                    Image = item.Name,
                    IsMain = item.IsMain
                });
            }


            if (!ModelState.IsValid)
            {
                
                return View(new ProductEditVM { Images = images });

            }


            List<ProductImage> newImages = new();

         

           if(request.NewImages is not null)
            {
                foreach (var item in request.NewImages)
                {


                    if (!item.CheckFileType("image/"))
                    {
                        ModelState.AddModelError("NewImages", "Input can accept only image format");
                        return View(request);

                    }
                    if (!item.CheckFileSize(500))
                    {
                        ModelState.AddModelError("NewImages", "Image size must be max 500 KB ");
                        return View(request);
                    }


                }
            }

            if(request.NewImages is not null)
            {

                foreach (var item in request.NewImages)
                {
                    string oldPath = _env.GenerateFilePath("img", item.Name);
                    oldPath.DeleteFileFromLocal();
                    string fileName = Guid.NewGuid().ToString() + "-" + item.FileName;
                    string newPath = _env.GenerateFilePath("img", fileName);

                    await item.SaveFileToLocalAsync(newPath);


                    product.ProductImages.Add(new ProductImage { Name = fileName });

                }
            }


            if (request.Name is not null)
            {
                product.Name = request.Name;
            }
            if (request.Description is not null)
            {
                product.Description = request.Description;
            }

            if (request.CategoryId != product.CategoryId)
            {
                product.CategoryId = request.CategoryId;
            }

            if(decimal.Parse(request.Price.Replace(".",",")) != product.Price)
            {
                product.Price = decimal.Parse(request.Price.Replace(".", ","));
            }
           

           


            await _productService.EditAsync();
            return RedirectToAction(nameof(Index));

        }

        

        [HttpPost]
        public async Task<IActionResult> IsMain(int? id)
        {
            if (id is null) return BadRequest();
            var productImage = await _productService.GetProductImageByIdAsync((int)id);

            if (productImage is null) return NotFound();


            var productId = productImage.ProductId;

            var product = await _productService.GetByIdWithAllDatas(productId);

            foreach (var item in product.ProductImages)
            {
                item.IsMain = false;
            }
            productImage.IsMain = true;



            await _productService.EditAsync();

            return Ok();

        }

        [HttpPost]
        public async Task<IActionResult> ImageDelete(int? id)
        {
            if (id is null) return BadRequest();
            var productImage = await _productService.GetProductImageByIdAsync((int)id);

            if (productImage is null) return NotFound();

            //var images=await _productService.GetProductByNameAsync(productName);

            //foreach (var item in images.ProductImages)
            //{
            //    item.IsMain = false;
            //}

              string path = _env.GenerateFilePath("img", productImage.Name);
                path.DeleteFileFromLocal();
        
            await _productService.ImageDeleteAsync(productImage);

            return Ok();

        }
    }
}

