using CashCrusaders.Domain.Models;

namespace CashCrusaders.Domain.Interfaces
{
    public interface IProductsRepository
    {
        Task<List<Product>> GetAll();
        Task<List<Product>> GetProductsBySupplierID(int supplierID);
        Task<Product> Insert(Product product);
        Task<int> Commit();
    }
}
