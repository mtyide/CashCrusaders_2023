using CashCrusaders.Domain.Models;

namespace CashCrusaders.Domain.Interfaces
{
    public interface IProductsService
    {
        Task<List<Product>> GetAll();
        Task<Product> Insert(Product product);
    }
}
