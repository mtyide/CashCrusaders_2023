using CashCrusaders.Domain.Interfaces;
using CashCrusaders.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace CashCrusaders.Data.Repositories
{
    public class OrdersRepository : IOrdersRepository
    {
        private readonly Storage _storage;
        private readonly DbSet<Order> _orders;
        public OrdersRepository(Storage storage)
        {
            _storage = storage;
            _orders = storage.Set<Order>();
        }

        public async Task<int> Commit()
        {
            return await _storage.SaveChangesAsync();
        }

        public Task<List<Order>> GetAll() => _orders.Include(x => x.Lines).ToListAsync();

        public async Task<Order> Insert(Order order)
        {
            _orders.Add(order);
            await Commit();

            return order;
        }
    }
}
