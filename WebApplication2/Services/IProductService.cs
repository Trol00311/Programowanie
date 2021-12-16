using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Entities;
using WebApplication2.Models;

namespace WebApplication2.Services
{
    public interface IProductService
    {
        Task Add(ProductsModel product);

        Task<IEnumerable<ProductEntity>> GetAll(string name);
    }
}
