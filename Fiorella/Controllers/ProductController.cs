using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Fiorella.Models;
using Fiorella.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;


namespace Fiorella.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;
        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        public async Task<IActionResult> Index(int? id)
        {
            if (id is null) return BadRequest();
            Product product = await _productService.GetByIdWithAllDatas((int)id);
            if (product is null) return NotFound();

            return View(product);
        }

        
    }
}

