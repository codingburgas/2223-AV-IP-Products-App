#pragma warning disable 8618

using Microsoft.EntityFrameworkCore;

namespace ProductWeb.Models.Data
{
    public class ProductContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=ProductsDb");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Products>().Property(x => x.Id).IsRequired();
        }
        public DbSet<Products> Products { get; set; }
    }
}
