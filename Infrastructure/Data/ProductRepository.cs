using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using core.Entities;
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
            return await this._context.Products
            .Include(p=>p.ProductBrand)
            .Include(p=>p.ProductType)
            .ToListAsync();
        }

        public async Task<Product> GetProductsByIdAsync(int id)
        {
           return await this._context.Products
           .Include(p=>p.ProductBrand)
           .Include(p=>p.ProductType)
           .FirstOrDefaultAsync(p=>p.Id==id);
        }

        public async Task<IReadOnlyList<ProductBrand>> GetProductBrandsAsync()
        {
            return await this._context.ProductBrands.ToListAsync();
        }
        public async Task<IReadOnlyList<ProductType>> GetProductTypesAsync()
        {
            return await this._context.ProductTypes.ToListAsync();
        }

      
    }
}