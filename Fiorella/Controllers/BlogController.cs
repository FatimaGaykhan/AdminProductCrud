using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Fiorella.Models;
using Fiorella.Services;
using Fiorella.Services.Interfaces;
using Fiorella.ViewModels.Blog;
using Fiorella.ViewModels.Categories;
using Microsoft.AspNetCore.Mvc;


namespace Fiorella.Controllers
{
    public class BlogController : Controller
    {
        private readonly IBlogService _blogService;
        public BlogController(IBlogService blogService)
        {
            _blogService = blogService;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _blogService.GetAllAsync());
        }

    }
}

