using System;
using System.ComponentModel.DataAnnotations;

namespace Fiorella.ViewModels.Blog
{
	public class BlogCreateVM
	{
        [Required]
        public IFormFile Image { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string Title { get; set; }

    }
}

