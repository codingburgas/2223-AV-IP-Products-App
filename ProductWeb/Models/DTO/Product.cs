using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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

        [NotMapped]
        [DataType(DataType.Date)]
        public DateOnly createdOn { get; set; }

        [NotMapped]
        [DataType(DataType.Date)]
        public DateOnly updatedOn { get; set; }
    }
}
