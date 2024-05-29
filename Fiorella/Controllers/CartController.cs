using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Fiorella.Models;
using Fiorella.Services.Interfaces;
using Fiorella.ViewModels.Baskets;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Fiorella.Controllers
{
    public class CartController : Controller
    {
        private readonly IHttpContextAccessor _accessor;
        private readonly AppDbContext _context;
        private readonly IProductService _productService;

        public CartController(IHttpContextAccessor accessor,
                              AppDbContext context,
                              IProductService productService)
        {
            _accessor = accessor;
            _context = context;
            _productService = productService;
        }

        public async Task<IActionResult> Index()
        {

            List<BasketVM> basketDatas = new();

            if (_accessor.HttpContext.Request.Cookies["basket"] is not null)
            {
                basketDatas = JsonConvert.DeserializeObject<List<BasketVM>>(_accessor.HttpContext.Request.Cookies["basket"]);
            }

            var dbProducts = await _productService.GetAllAsync();


            List<BasketProductVM> basketProducts = new();

            foreach (var item in basketDatas)
            {
                var dbProduct = dbProducts.FirstOrDefault(m => m.Id == item.Id);

                basketProducts.Add(new BasketProductVM
                {
                    Id = dbProduct.Id,
                    Name = dbProduct.Name,
                    Description = dbProduct.Description,
                    CategoryName = dbProduct.Category.Name,
                    MainImage = dbProduct.ProductImages.FirstOrDefault(m => m.IsMain).Name,
                    Price = dbProduct.Price,
                    Count = item.Count,
                });
            }

            BasketDetailVM basketDetail = new()
            {
                Products = basketProducts,
                TotalPrice = basketDatas.Sum(m => m.Count * m.Price),
                TotalCount = basketDatas.Count
            };

            return View(basketDetail);

        }


        [HttpPost]
        public IActionResult DeleteProductFromBasket(int? id)
        {
            if (id is null) return BadRequest();

            List<BasketVM> basketDatas = new();

            if (_accessor.HttpContext.Request.Cookies["basket"] is not null)
            {
                basketDatas = JsonConvert.DeserializeObject<List<BasketVM>>(_accessor.HttpContext.Request.Cookies["basket"]);
            }

            basketDatas = basketDatas.Where(m => m.Id != id).ToList();

            _accessor.HttpContext.Response.Cookies.Append("basket", JsonConvert.SerializeObject(basketDatas));


            int totalCount = basketDatas.Sum(m => m.Count);
            decimal totalPrice = basketDatas.Sum(m => m.Count * m.Price);
            int basketCount = basketDatas.Count;

            return Ok(new { basketCount, totalCount, totalPrice });
        }

        [HttpPost]
        public IActionResult IncreseDecreaseBasketCount(int ? id ,int count)
        {
            if (id is null) return BadRequest();

            List<BasketVM> basketDatas = new();

            if (_accessor.HttpContext.Request.Cookies["basket"] is not null)
            {
                basketDatas = JsonConvert.DeserializeObject<List<BasketVM>>(_accessor.HttpContext.Request.Cookies["basket"]);
            }

             BasketVM product = basketDatas.FirstOrDefault(m => m.Id == id);

            product.Count = count;

            _accessor.HttpContext.Response.Cookies.Append("basket", JsonConvert.SerializeObject(basketDatas));

            int totalCount = basketDatas.Sum(m => m.Count);
            decimal totalPrice = basketDatas.Sum(m => m.Count * m.Price);

            return Ok(new {  totalCount, totalPrice });

        }
    }
}

