using Catalog.Core.Entities;

namespace Catalog.Core.Repositories
{
    public interface IProductRepository
    {
        Task<Product> GetProductByIdAsync(int id);
        Task<IEnumerable<Product>> GetProductsAsync();
        Task<IEnumerable<Product>> GetProductByNameAsync(string name);
        Task<IEnumerable<Product>> GetProductByBrandAsync(string brandName);
        Task<Product> CreateProductAsync(Product product);
        Task<Product> UpdateProductAsync(Product Product);
        Task<Product> DeleteProductAsync(string id);
    }
}
