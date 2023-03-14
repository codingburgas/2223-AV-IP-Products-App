using Microsoft.EntityFrameworkCore;
using ProductWeb.Models.DTO;

namespace ProductWeb.Models.Domain
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options):base(options)
        {
            
        }

        public DbSet<Product> products { get; set; }
    }
}
