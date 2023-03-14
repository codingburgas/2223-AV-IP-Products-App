using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProducWeb.Models;

namespace ProductWeb.Data
{
    public class ProductWebContext : DbContext
    {
        public ProductWebContext (DbContextOptions<ProductWebContext> options)
            : base(options)
        {
        }

        public DbSet<ProducWeb.Models.Product> Product { get; set; } = default!;
    }
}
