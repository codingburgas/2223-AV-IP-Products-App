using System.ComponentModel.DataAnnotations;

namespace ProductWeb.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MinLength(3)]
        [MaxLength(50)]
        public string Name { get; set; }
        [MaxLength(200)]
        [Required]
        public string Description { get; set; }
        [Range(1,200)]
        [Required]
        public int Price { get; set; }
        [Required]
        public DateTime DateOfCreation { get; set; }
        [Required]
        public DateTime DateOfLastCahnge { get; set; }
    }
}
