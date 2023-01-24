﻿using CashCrusaders.Domain.Interfaces;
using CashCrusaders.Domain.Models;

namespace CashCrusaders.Domain.Services
{
    public class ProductsService : IProductsService
    {
        private readonly IProductsRepository _productsRepository;
        public ProductsService(IProductsRepository productsService) 
        {
            _productsRepository = productsService;
        }

        public Task<List<Product>> GetAll()
        {
            return _productsRepository.GetAll();
        }

        public Task<Product> Insert(Product product)
        {
            return _productsRepository.Insert(product);
        }
    }
}
