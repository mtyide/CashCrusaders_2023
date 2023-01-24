using CashCrusaders.Domain.Models;

namespace CashCrusaders.Domain.Interfaces
{
    public interface ISuppliersService
    {
        Task<List<Supplier>> GetAll();
        Task<Supplier> Insert(Supplier supplier);
    }
}
