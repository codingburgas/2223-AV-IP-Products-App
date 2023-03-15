using Microsoft.EntityFrameworkCore;
using ProductsProject.Models;

namespace ProductsProject.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }

        public DbSet<Products> Products { get; set; }
    }
}
