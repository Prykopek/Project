using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Projekt.API.Models;
namespace Projekt.API.Data
{
    public class ProductRepository: IProductRepository
    {

        private readonly DataContext _context;

        public ProductRepository(DataContext context)
        {
            _context = context;
        }
        public async Task<Product> AddProduct(Product product)
        {
         await _context.Products.AddAsync(product);
         await _context.SaveChangesAsync();

           return product;  
        }
    }
}