using CashCrusaders.Domain.Models;

namespace CashCrusaders.Domain.Interfaces
{
    public interface ISuppliersRepository
    {
        Task<List<Supplier>> GetAll();
        Task<Supplier> GetById(int id);
        Task<Supplier> Insert(Supplier supplier);
        Task<int> Commit();
    }
}
