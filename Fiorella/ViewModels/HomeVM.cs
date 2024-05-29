using System;
using Fiorella.Models;
using Fiorella.ViewModels.Blog;
using Fiorella.ViewModels.Expert;

namespace Fiorella.ViewModels
{
	public class HomeVM
	{
		public IEnumerable<BlogVM> Blogs { get; set; }
		public IEnumerable<ExpertVM> Experts { get; set; }
		public IEnumerable<Category> Categories{ get; set; }
		public IEnumerable<Product> Products { get; set; }



	}
}

