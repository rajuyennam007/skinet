using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Core.Entities;

namespace Infrastructure.Data
{
    public class StorageContext: DbContext
    {
       public StorageContext(DbContextOptions<StorageContext> options) : base(options)
       {

       }

       public DbSet<Product> Products1 {get;set;}
    }
}