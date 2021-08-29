using Catalog.API.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Catalog.API.Repositories.Interfaces
{
    public interface IProductRepository
    {
        Task CreateProduct(Product createProduct);

        Task<bool> DeleteProduct(string id);

        Task<Product> GetProduct(string id);

        Task<IEnumerable<Product>> GetProducts();

        Task<IEnumerable<Product>> GetProductsByCategory(string categoryName);

        Task<IEnumerable<Product>> GetProductsByName(string name);
        Task<bool> UpdateProduct(Product updateProduct);
    }
}