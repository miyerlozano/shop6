


namespace Shop.web.Models
{
	using System.ComponentModel.DataAnnotations;
	using Microsoft.AspNetCore.Http;

	public class ProductViewModel : Product
	{
		[Display(Name = "Image")]
		public IFormFile ImageFile { get; set; }
	}

}
