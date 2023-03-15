namespace ProductsProject.Models
{
    public class Products
    {
        public int Id { get; set; } 
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;   
        public DateTime UpdatedDate { get; set; } = DateTime.Now;

    }
}
