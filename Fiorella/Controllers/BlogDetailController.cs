using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Fiorella.Models;
using Fiorella.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;


namespace Fiorella.Controllers
{
    public class BlogDetailController : Controller
    {
        private readonly IBlogService _blogService;
        public BlogDetailController(IBlogService blogService)
        {
            _blogService = blogService;
        }
        public async Task<IActionResult> Index(int? id)
        {
            if (id is null) return BadRequest();
            Blog blog = await _blogService.GetByIdAsync((int)id);
            if (blog is null) return NotFound();

            return View(blog);
        }
    }
}

