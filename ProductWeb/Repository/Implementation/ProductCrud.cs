using Microsoft.EntityFrameworkCore;
using ProductWeb.Models.Domain;
using ProductWeb.Models.DTO;
using ProductWeb.Repository.Interface;

namespace ProductWeb.Repository.Implementation
{
    public class ProductCrud : IProductCrud
    {
        private readonly DatabaseContext _databaseContext;

        public ProductCrud(DatabaseContext databaseContext)
        {
            this._databaseContext = databaseContext;
        }

        public virtual async Task<ICollection<Product>> GetAll()
        {
            return await _databaseContext.products.ToListAsync();
        }
    }
}
