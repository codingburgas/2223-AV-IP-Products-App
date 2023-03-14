using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ProducWeb.Models
{
	public class Product
	{
		[Key]
		public int Id { get; set; }

		[Required]
		[MinLength(3)]
		[StringLength(50)]
		public string Name { get; set; }

		[Required]
		[StringLength(200)]
		public string Description { get; set; }

        [Required]
        [Range(1, 200, ErrorMessage = "Price has to be between 1 and 200.")]
		public int Price { get; set; }

		public DateTime CreatedAt { get; set; }

		public DateTime UpdatedAt { get; set; }
	}
}