using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Fiorella.Helpers;
using Fiorella.Models;
using Fiorella.Services;
using Fiorella.Services.Interfaces;
using Fiorella.ViewModels.Categories;
using Fiorella.ViewModels.Products;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


namespace Fiorella.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ArchiveController : Controller
    {
        private readonly ICategoryService _categoryService;
        private readonly AppDbContext _context;
        public ArchiveController(ICategoryService categoryService,
                                              AppDbContext context)
        {
            _categoryService = categoryService;
            _context = context;
        }

        public async Task<IActionResult> Index(int page=1)
        {
            var categories = await _categoryService.GetAllPaginateArchiveAsync(page, 4);
            var mappedDatas = _categoryService.GetMappedDatasArchive(categories);

            int totalPage = await GetPageCountAsync(4);

            Paginate<CategoryArchiveVM> paginateDatas = new(mappedDatas, totalPage, page);

            return View(paginateDatas);
        }
        private async Task<int> GetPageCountAsync(int take)
        {
            int categoryCount = await _categoryService.GetCountAsync();

            return (int)Math.Ceiling((decimal)categoryCount / take);
        }




        [HttpPost]
        public async Task<IActionResult> SetToRestore(int? id)
        {
            if (id is null) return BadRequest();
            var category = await _categoryService.GetByIdAsync((int)id);
            if (category is null) return NotFound();

            category.SoftDeleted = !category.SoftDeleted;

            await _context.SaveChangesAsync();

            return Ok(category);
        }
    }
}

