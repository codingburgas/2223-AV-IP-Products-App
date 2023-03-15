using ProductWeb.Models.DTO;
using ProductWeb.Repository.Interface;
using AutoMapper;

namespace ProductWeb.Service
{
    public class ProductService : IProductService
    {
        private readonly IProductCrud _productCrud;
        public readonly IMapper _mapper;

        public ProductService(IProductCrud productCrud)
        {
            this._productCrud = productCrud;
        }

        public async Task<ICollection<Product>> GetAllAsync()
        {
            return await _productCrud.GetAllAsync();
        }

        public async Task<Status> UpdateAsync(EditProduct model)
        {
            return await _productCrud.UpdateAsync(model);
        }
    }
}
