using CashCrusaders.Domain.Interfaces;
using CashCrusaders.Domain.Models;

namespace CashCrusaders.Domain.Services
{
    public class OrdersService : IOrdersService
    {
        private readonly IOrdersRepository _ordersRepository;
        public OrdersService(IOrdersRepository ordersRepository) 
        {
            _ordersRepository = ordersRepository; 
        }

        public Task<List<Order>> GetAll()
        {
            return _ordersRepository.GetAll();
        }

        public Task<Order> Insert(Order order)
        {
            return _ordersRepository.Insert(order);
        }
    }
}
