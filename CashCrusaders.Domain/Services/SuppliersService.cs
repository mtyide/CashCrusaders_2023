using CashCrusaders.Domain.Interfaces;
using CashCrusaders.Domain.Models;

namespace CashCrusaders.Domain.Services
{
    public class SuppliersService : ISuppliersService
    {
        private readonly ISuppliersRepository _suppliersRepository;
        public SuppliersService(ISuppliersRepository suppliersRepository) 
        {
            _suppliersRepository = suppliersRepository;
        }

        public Task<List<Supplier>> GetAll()
        {
            return _suppliersRepository.GetAll();
        }

        public Task<Supplier> GetById(int id)
        {
            return _suppliersRepository.GetById(id);
        }

        public Task<Supplier> Insert(Supplier supplier)
        {
            return _suppliersRepository.Insert(supplier);
        }
    }
}
