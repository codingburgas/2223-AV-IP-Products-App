using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ProductWeb.Models
{
    public class Product
    { 
        [Required]
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Name has to be between 3 and 50 character.")]
        public string Name { get; set; }

        [StringLength(200, ErrorMessage = "Name has to be max 200 character.")]
        public string Description { get; set; }

        [Required]
        [IntegerValidator(MinValue = 1, MaxValue = 200)]
        public int Price { get; set; }

        [Required]
        public string DateCreated { get; } = DateTime.Now;

        public DateTime LastEdited { get; set; } ;
    }
}