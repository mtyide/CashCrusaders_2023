using CashCrusaders.Domain.Models;

namespace CashCrusaders.Domain.Interfaces
{
    public interface IProductsRepository
    {
        Task<List<Product>> GetAll();
        Task<Product> Insert(Product product);
        Task<int> Commit();
    }
}
