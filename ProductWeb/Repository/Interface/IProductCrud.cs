using ProductWeb.Models.DTO;

namespace ProductWeb.Repository.Interface
{
    public interface IProductCrud
    {
        Task<ICollection<Product>> GetAllAsync();
    }
}
