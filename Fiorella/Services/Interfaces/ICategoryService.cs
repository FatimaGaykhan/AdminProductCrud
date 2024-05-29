using System;
using Fiorella.Models;
using Fiorella.ViewModels.Categories;
using Fiorella.ViewModels.Products;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Fiorella.Services.Interfaces
{
	public interface ICategoryService
	{
		Task<IEnumerable<Category>> GetAllAsync();
		Task<IEnumerable<CategoryProductVM>> GetAllWithProductCountAsync();
		Task<Category> GetByIdAsync(int id);
		Task<bool> ExistAsync(string name);
		Task CreateAsync(Category category);
		Task DeleteAsync(Category category);
		Task<Category> DetailAsync(int id);
		Task<bool> ExistExceptByIdAsync(int id, string name);
		Task EditAsync(Category category,string request);
        Task<IEnumerable<CategoryArchiveVM>> GetAllArchiveAsync();
        Task<IEnumerable<Category>> GetAllPaginateArchiveAsync(int page, int take);
        Task<IEnumerable<Category>> GetAllPaginateAsync(int page, int take);
        Task<int> GetCountAsync();
        IEnumerable<CategoryArchiveVM> GetMappedDatasArchive(IEnumerable<Category> categories);
        IEnumerable<CategoryProductVM> GetMappedDatas(IEnumerable<Category> categories);
		Task<SelectList> GetAllSelectedAsync();

    }
}

