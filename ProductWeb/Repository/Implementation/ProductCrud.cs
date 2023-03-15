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

        public virtual async Task<ICollection<Product>> GetAllAsync()
        {
            return await _databaseContext.
                products.
                ToListAsync();
        }

        public virtual async Task<Status> UpdateAsync(EditProduct item)
        {
            var status = new Status();

            try
            {
                _databaseContext.products.Update(item);
                await _databaseContext.SaveChangesAsync();

                status.Code = 1;
                status.Message = "Product has been updated successfully!";
                return status;
            }
            catch (Exception)
            {
                status.Code = 0;
                status.Message = "Product has not been updated successfully!";
                return status;
            }
        }
    }
}
