using CashCrusaders.Domain.Models;

namespace CashCrusaders.Domain.Interfaces
{
    public interface IOrdersService
    {
        Task<List<Order>> GetAll();
        Task<Order> Insert(Order order);
    }
}
