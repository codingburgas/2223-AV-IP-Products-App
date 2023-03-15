using System.ComponentModel.DataAnnotations;

namespace ProductsProject.Models
{
    public class Products
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public decimal Price { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;   
        public DateTime UpdatedDate { get; set; } = DateTime.Now;

    }
}
