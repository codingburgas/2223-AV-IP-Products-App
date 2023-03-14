using System.ComponentModel.DataAnnotations;

namespace ProductWeb.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MinLength(3,ErrorMessage ="Name must be at least 3 characters long.")]
        [MaxLength(50, ErrorMessage = "Name must be at most 50 characters long.")]
        [RegularExpression(@"^[a-zA-Z]+$",
         ErrorMessage = "Only letters are allowed.")]
        public string Name { get; set; }
        [MaxLength(200, ErrorMessage = "Description must be at most 200 characters long.")]
        [Required]
        public string Description { get; set; }
        [Range(1,200,ErrorMessage ="Price must be between the range of 1 and 200")]
        [Required]
        public int Price { get; set; }
        [Required]
        public DateTime DateOfCreation { get; set; }
        [Required]
        public DateTime DateOfLastCahnge { get; set; }
    }
}
