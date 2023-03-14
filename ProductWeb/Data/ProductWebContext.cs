using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProductWeb.Models;

namespace ProductWeb.Data
{
    public class ProductWebContext : DbContext
    {
        public ProductWebContext (DbContextOptions<ProductWebContext> options)
            : base(options)
        {
        }

        public DbSet<Product> Product { get; set; } = default!;
    }
}
