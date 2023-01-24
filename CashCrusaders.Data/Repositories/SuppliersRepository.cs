using CashCrusaders.Domain.Interfaces;
using CashCrusaders.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace CashCrusaders.Data.Repositories
{
    public class SuppliersRepository : ISuppliersRepository
    {
        private readonly Storage _storage;
        private readonly DbSet<Supplier> _suppliers;
        public SuppliersRepository(Storage storage)
        {
            _storage = storage;
            _suppliers = storage.Set<Supplier>();
        }

        public async Task<int> Commit()
        {
            return await _storage.SaveChangesAsync();
        }

        public Task<List<Supplier>> GetAll() => _suppliers.ToListAsync();

        public async Task<Supplier> Insert(Supplier supplier)
        {
            _suppliers.Add(supplier);
            await Commit();

            return supplier;
        }
    }
}
