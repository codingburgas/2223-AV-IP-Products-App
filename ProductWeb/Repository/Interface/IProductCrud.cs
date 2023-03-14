﻿using ProductWeb.Models.DTO;

namespace ProductWeb.Repository.Interface
{
    public interface IProductCrud
    {
        Task<ICollection<Product>> GetAllAsync();
        Task<Status> UpdateAsync(EditProduct item);
        Task<Product> GetByIdAsync(int id);
    }
}