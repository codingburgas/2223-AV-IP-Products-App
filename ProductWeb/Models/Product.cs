using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ProducWeb.Models
{
	public class Product
	{
		[Key]
		public int Id { get; set; }

		[Required(ErrorMessage = "This field is required")]
		[MinLength(3)]
		[StringLength(50)]
        [RegularExpression("^((?!^Name$)[a-zA-Z '])+$", ErrorMessage = "The field is not a valid name")]
        public string Name { get; set; }

		[Required(ErrorMessage = "This field is required")]
		[StringLength(200)]
		public string Description { get; set; }

        [Required(ErrorMessage = "This field is required")]
        [Range(1, 200, ErrorMessage = "Price has to be between 1 and 200.")]
		public int Price { get; set; }

		public DateTime CreatedAt { get; set; }

		public DateTime UpdatedAt { get; set; }
	}
}