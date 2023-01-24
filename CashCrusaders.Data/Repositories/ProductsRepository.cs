using CashCrusaders.Domain.Interfaces;
using CashCrusaders.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace CashCrusaders.Data.Repositories
{
    public class ProductsRepository : IProductsRepository
    {
        private readonly Storage _storage;
        private readonly DbSet<Product> _products;
        public ProductsRepository(Storage storage)
        {
            _storage = storage;
            _products = storage.Set<Product>();
        }

        public async Task<int> Commit()
        {
            return await _storage.SaveChangesAsync();
        }

        public Task<List<Product>> GetAll() => _products.ToListAsync();

        public async Task<Product> Insert(Product product)
        {
            _products.Add(product);
            await Commit();

            return product;
        }
    }
}
