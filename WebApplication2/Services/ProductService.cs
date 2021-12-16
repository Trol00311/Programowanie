using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Database;
using WebApplication2.Entities;
using WebApplication2.Models;

namespace WebApplication2.Services
{
    public class ProductService : IProductService
    {
        private readonly AppDbContext _dbContext;

        public ProductService(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task Add(ProductsModel product)
        {
             var entity = new ProductEntity
             {
               Name = product.Name,
               Description = product.Description,
                  IsVisible = product.IsVisible,
             };

             await _dbContext.Products.AddAsync(entity);
             await _dbContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<ProductEntity>> GetAll(string name)
        {
            IQueryable<ProductEntity> productsQuery = _dbContext.Products;
            if (!string.IsNullOrEmpty(name))
            {
                productsQuery = productsQuery.Where(x => x.Name.Contains(name));
            }
            var products = await productsQuery.ToListAsync();
            return products;
        }
    }
}
