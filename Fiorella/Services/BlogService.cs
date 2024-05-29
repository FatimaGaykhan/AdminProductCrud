using System;
using Fiorella.Models;
using Fiorella.Services.Interfaces;
using Fiorella.ViewModels.Blog;
using Microsoft.EntityFrameworkCore;

namespace Fiorella.Services
{
    public class BlogService : IBlogService
    {
        private readonly AppDbContext _context;

        public BlogService(AppDbContext context)
        {
            _context = context;
        }

        public async Task CreateAsync(Blog blog)
        {
            await _context.AddAsync(blog);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(Blog blog)
        {
            _context.Blogs.Remove(blog);
            await _context.SaveChangesAsync();
        }

        public async Task<bool> ExistExceptByIdAsync(int id, string title)
        {
            return await _context.Blogs.AnyAsync(m => m.Title == title && m.Id != id);

        }



        public async Task<Blog> DetailAsync(int id)
        {
            return await _context.Blogs.Where(m => m.Id == id).FirstOrDefaultAsync();
        }

        public async Task<bool> ExistAsync(string name)
        {
            return await _context.Blogs.AnyAsync(m => m.Title.Trim() == name.Trim());

        }

        public async Task<IEnumerable<BlogVM>> GetAllAsync(int? take=null)
        {
            IEnumerable<Blog> blogs;
            if (take is null)
            {
                blogs= await _context.Blogs.ToListAsync();

            }
            else
            {
                 blogs = await _context.Blogs.Take((int)take).ToListAsync();

            }
            return blogs.Select(m => new BlogVM { Id=m.Id,Title = m.Title, Description = m.Description, Image = m.Image, CreatedDate = m.CreatedDate.ToString("MM.dd.yyyy") });
        }

        public async Task<Blog> GetByIdAsync(int id)
        {
            return await _context.Blogs.Where(m => m.Id == id).FirstOrDefaultAsync();
        }

        public async Task EditAsync(Blog blog, BlogEditVM request)
        {
            blog.Title = request.Title;
            blog.Description = request.Description;

            await _context.SaveChangesAsync();
        }
    }
}

