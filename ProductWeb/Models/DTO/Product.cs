using System.ComponentModel.DataAnnotations;

namespace ProductWeb.Models.DTO
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MinLength(3)]
        [MaxLength(50)]
        [RegularExpression("^[a-zA-Z ]*$")]
        public string Name { get; set; }

        [Required]
        [MaxLength(200)]
        public string Description { get; set; }

        [Required]
        [MinLength(1)]
        [MaxLength(200)]
        public byte Price { get; set; }

        public DateOnly createdOn { get; set; }

        public DateOnly updatedOn { get; set; }
    }
}
