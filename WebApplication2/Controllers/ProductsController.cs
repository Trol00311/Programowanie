using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Database;
using WebApplication2.Entities;
using WebApplication2.Models;
using WebApplication2.Services;

namespace WebApplication2.Controllers
{
    public class ProductsController: Controller
    {
        private readonly AppDbContext _dbContext;
        private readonly IProductService _productService;

        public ProductsController(AppDbContext dbContext, IProductService productService)
        {
            _dbContext = dbContext;
            _productService = productService;
        }
        public IActionResult Index ()
        {
            return View();
        }

        public async Task<IActionResult> Add (ProductsModel product)
        {


            await _productService.Add(product);

            var viewModel = new ProductStatsViewModel
            {
                NameLength = product.Name.Length,
                DescriptionLength = product.Description.Length,
            };
            return View(viewModel);
        }

        [HttpGet]
        public async Task<IActionResult> List(string name)
        {
            var products = await _productService.GetAll(name);
            return View(products);
        }


    }
}
