using CashCrusaders.Domain.Models;

namespace CashCrusaders.Domain.Interfaces
{
    public interface ISuppliersRepository
    {
        Task<List<Supplier>> GetAll();
        Task<Supplier> Insert(Supplier supplier);
        Task<int> Commit();
    }
}
