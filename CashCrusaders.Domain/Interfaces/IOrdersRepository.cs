using CashCrusaders.Domain.Models;

namespace CashCrusaders.Domain.Interfaces
{
    public interface IOrdersRepository
    {
        Task<List<Order>> GetAll();
        Task<Order> Insert(Order order);
        Task<int> Commit();
    }
}
