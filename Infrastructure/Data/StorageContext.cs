using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Core.Entities;
using System.Diagnostics.Contracts;
using System.Security.Cryptography.X509Certificates;
using core.Entities;
using System.Reflection;

namespace Infrastructure.Data
{
    public class StorageContext: DbContext
    {
       public StorageContext(DbContextOptions<StorageContext> options) : base(options)
       {

       }

       public DbSet<Product> Products {get;set;}
       public DbSet<ProductBrand> ProductBrands{get;set;}
       public DbSet<ProductType> ProductTypes{get;set;}
       protected override void OnModelCreating(ModelBuilder modelBuilder)
       {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
       }
    }
}