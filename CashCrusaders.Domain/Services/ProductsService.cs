using CashCrusaders.Domain.Interfaces;
using CashCrusaders.Domain.Models;

namespace CashCrusaders.Domain.Services
{
    public class ProductsService : IProductsService
    {
        private readonly IProductsRepository _productsRepository;
        public ProductsService(IProductsRepository productsRepository) 
        {
            _productsRepository = productsRepository;
        }

        public Task<List<Product>> GetAll()
        {
            return _productsRepository.GetAll();
        }

        public Task<List<Product>> GetProductsBySupplierID(int supplierID)
        {
            return _productsRepository.GetProductsBySupplierID(supplierID);
        }

        public Task<Product> Insert(Product product)
        {
            return _productsRepository.Insert(product);
        }
    }
}
