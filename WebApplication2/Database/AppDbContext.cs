using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Entities;

namespace WebApplication2.Database
{
    public class AppDbContext : DbContext
    {
        public DbSet<ProductEntity> Products {get;set;}

        public AppDbContext(DbContextOptions options)
            : base(options)
        { 
        }
    }
}
