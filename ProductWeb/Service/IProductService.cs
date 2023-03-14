using ProductWeb.Models.DTO;

namespace ProductWeb.Service
{
    public interface IProductService
    {
        public Task<ICollection<Product>> GetAllAsync();
        public Task<Status> UpdateAsync(EditProduct model);
        public Task<Product> GetByIdAsync(int id);
    }
}
