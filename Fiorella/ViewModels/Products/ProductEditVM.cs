using System;
namespace Fiorella.ViewModels.Products
{
	public class ProductEditVM
	{

        public string Name { get; set; }

        public string Description { get; set; }

        public string Price { get; set; }

        public int CategoryId { get; set; }

        public List<ProductImageVM> Images { get; set; }

        public List<IFormFile>? NewImages { get; set; }
    }
}

