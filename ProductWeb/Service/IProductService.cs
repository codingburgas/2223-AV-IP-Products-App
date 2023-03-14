using ProductWeb.Models.DTO;

namespace ProductWeb.Service
{
    public interface IProductService
    {
        public Task<ICollection<Product>> GetAllAsync();
    }
}
