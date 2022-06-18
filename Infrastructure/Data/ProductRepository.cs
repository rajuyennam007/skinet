using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using core.Interfaces;
using Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data
{
    public class ProductRepository : IProductRepository
    {
        private readonly StorageContext _context;
        public ProductRepository(StorageContext context)
        {
            _context=context;
        }
        public async Task<IReadOnlyList<Product>> GetProductsAsync()
        {
            return await this._context.Products.ToListAsync();
        }

        public async Task<Product> GetProductsByIdAsync(int id)
        {
           return await this._context.Products.FindAsync(id);
        }
    }
}