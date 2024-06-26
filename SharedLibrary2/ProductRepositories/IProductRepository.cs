﻿using SharedLibrary.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SharedLibrary.ProductRepositories
{
    public interface IProductRepository
    {
        Task<Product> AddProductAsync(Product model);
        Task<Product> UpdateProductAsync(Product model);
        Task<Product> DeleteProductAsync(int productId);
        Task<List<Product>> GetAllProductsAsync();
        Task<Product> GetProductByIdAsync(int productId);
    }
}