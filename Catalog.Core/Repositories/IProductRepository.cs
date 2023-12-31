using Catalog.Core.Entities;
using Catalog.Core.Specs;

namespace Catalog.Core.Repositories
{
    public interface IProductRepository
    {
        Task<Product> GetProductByIdAsync(string id);
        Task<Pagination<Product>> GetAllProductsAsync(CatalogSpecParams catalogSpecParams);
        Task<IEnumerable<Product>> GetProductListByNameAsync(string name);
        Task<IEnumerable<Product>> GetProductListByBrandAsync(string brandName);
        Task<Product> CreateProductAsync(Product product);
        Task<bool> UpdateProductAsync(Product Product);
        Task<bool> DeleteProductAsync(string id);
    }
}
