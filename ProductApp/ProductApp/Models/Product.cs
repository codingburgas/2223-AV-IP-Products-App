using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ProductApp.Models
{
    public class Product
    {
        [Required]
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Name must be between 1 and 30 characters.")]
        public string Name { get; set; }

        [StringLength(200, ErrorMessage = "Name must be max to 200 character.")]
        public string Description { get; set; }

        [Required]
        [IntegerValidator(MinValue = 1, MaxValue = 200)]
        public int Price { get; set; }

        [Required]
        public string DateCreated { get; } = DateTime.Now;

        public DateTime LastEdited { get; set; };
    }
}