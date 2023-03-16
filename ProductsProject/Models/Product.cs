using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;

namespace ProductsProject.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Range(3,50,ErrorMessage="Name should be between 3 and 50 characters!")]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        [Column(TypeName = "decimal(5, 2)")]
        public decimal Price { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;   
        public DateTime UpdatedDate { get; set; } = DateTime.Now;

    }
}
