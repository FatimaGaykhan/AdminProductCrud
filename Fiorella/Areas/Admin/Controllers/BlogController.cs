using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Fiorella.Extensions;
using Fiorella.Models;
using Fiorella.Services;
using Fiorella.Services.Interfaces;
using Fiorella.ViewModels.Blog;
using Fiorella.ViewModels.Sliders;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


namespace Fiorella.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class BlogController : Controller
    {
        private readonly IBlogService _blogService;
        private readonly IWebHostEnvironment _env;

        public BlogController(IBlogService blogService,
                               IWebHostEnvironment env)
        {
            _blogService = blogService;
            _env = env;
        } 

        public async Task<IActionResult> Index()
        {
            return View(await _blogService.GetAllAsync());
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(BlogCreateVM request)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            bool existBlog = await _blogService.ExistAsync(request.Title);
            if (existBlog)
            {
                ModelState.AddModelError("Title", "This blog name already exist");

                return View();
            }


            if (!request.Image.CheckFileType("image/"))
            {
                ModelState.AddModelError("Image", "Input can accept only image format");
                return View();
            }

            if (!request.Image.CheckFileSize(200))
            {
                ModelState.AddModelError("Image", "Image size  must be max 200KB");
                return View();
            }

            string fileName = Guid.NewGuid().ToString() + "-" + request.Image.FileName;

            string path = _env.GenerateFilePath("img", fileName);

            await request.Image.SaveFileToLocalAsync(path);

            await _blogService.CreateAsync(new Blog { Title = request.Title, Description = request.Description, Image = fileName});

            return RedirectToAction(nameof(Index));
        }


        [HttpGet]
        public async Task<IActionResult> Detail(int? id)
        {
            return View(await _blogService.DetailAsync((int)id));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id is null) return BadRequest();

            var blog = await _blogService.GetByIdAsync((int)id);

            if (blog is null) return NotFound();

            string path = _env.GenerateFilePath("img", blog.Image);

            path.DeleteFileFromLocal();

            await _blogService.DeleteAsync(blog);

            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id is null) return BadRequest();

            var blog = await _blogService.GetByIdAsync((int)id);

            if (blog is null) return NotFound();

            return View(new BlogEditVM { Title=blog.Title,Description=blog.Description,Image = blog.Image });
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> Edit(int? id, BlogEditVM request)
        {
            try
            {
                if (!ModelState.IsValid)
                {

                    var existBlog = await _blogService.GetByIdAsync((int)id);


                    return View(new BlogEditVM {  Image = existBlog.Image });
                }

                if (id is null) return BadRequest();

                if (await _blogService.ExistExceptByIdAsync((int)id, request.Title))
                {
                    ModelState.AddModelError("Title", "This blog title already exist");
                    return View();
                }


                var blog = await _blogService.GetByIdAsync((int)id);

                if (blog is null) return NotFound();

                //if (blog.Title.Trim() == request.Title.Trim())
                //{
                //    blog.Title = request.Title;
                //}

                //if (blog.Description.Trim() == request.Description.Trim())
                //{
                //    blog.Description = blog.Description;
                //}

                //if (request.NewImage is null) return RedirectToAction(nameof(Index));

                if (request.NewImage != null)
                {
                    if (!request.NewImage.CheckFileType("image/"))
                    {
                        ModelState.AddModelError("NewImage", "Input can accept only image format");
                        request.Image = blog.Image;
                        return View(request);
                    }

                    if (!request.NewImage.CheckFileSize(200))
                    {
                        ModelState.AddModelError("NewImage", "Image size  must be max 200KB");
                        request.Image = blog.Image;
                        return View(request);
                    }

                    string oldPath = _env.GenerateFilePath("img", blog.Image);

                    oldPath.DeleteFileFromLocal();

                    string fileName = Guid.NewGuid().ToString() + "-" + request.NewImage.FileName;


                    string newPath = _env.GenerateFilePath("img", fileName);

                    await request.NewImage.SaveFileToLocalAsync(newPath);

                    blog.Image = fileName;
                }


                await _blogService.EditAsync(blog, request);

                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                return BadRequest();
            }

        }
    }
}

