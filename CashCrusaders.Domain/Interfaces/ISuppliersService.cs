using CashCrusaders.Domain.Models;

namespace CashCrusaders.Domain.Interfaces
{
    public interface ISuppliersService
    {
        Task<List<Supplier>> GetAll();
        Task<Supplier> GetById(int id);
        Task<Supplier> Insert(Supplier supplier);
    }
}
