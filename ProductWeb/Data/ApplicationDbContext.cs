using Microsoft.EntityFrameworkCore;
using ProductWeb.Models;

namespace ProductWeb.Data
{
        public class ApplicationDbContext : DbContext
        {
            public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
            {

            }

            public DbSet<Product> Products { get; set; }
        }
}
