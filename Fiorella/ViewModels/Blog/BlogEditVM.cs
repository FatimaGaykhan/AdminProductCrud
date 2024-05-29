using System;
using System.ComponentModel.DataAnnotations;

namespace Fiorella.ViewModels.Blog
{
	public class BlogEditVM
	{
        [Required(ErrorMessage = "This input can't be empty")]
        [StringLength(20)]
        public string Title { get; set; }

        [Required(ErrorMessage = "This input can't be empty")]
        public string Description { get; set; }

        public string Image { get; set; }

        public IFormFile NewImage { get; set; }

    }
}

