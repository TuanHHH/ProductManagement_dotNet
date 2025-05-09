﻿using ProductManagementModule.Domain;

namespace ProductManagementModule.Repositories
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetAllProducts();
        Product GetProductById(long id);
        void AddProduct(Product product);
        void UpdateProduct(Product product);
        void DeleteProduct(long id);

    }
}
