using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Projekt.API.Data;
using Projekt.API.Dtos;
using Projekt.API.Models;

namespace Projekt.API.Controllers
{   [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductRepository _repo;
        private readonly IConfiguration _config;
        private readonly DataContext _context;
        public ProductsController(IProductRepository repo, IConfiguration config,DataContext context)
        {
            _config = config;
            _repo = repo;
            _context = context;
        }
        
        // GET api/products
        [AllowAnonymous]
        [HttpGet]
        public async Task<IActionResult> GetProduct()
        {
            var products =await _context.Products.ToListAsync();
            return Ok(products);
        }

        // GET api/values/5
        [AllowAnonymous]
        [HttpGet("{id}")]
        public async Task<IActionResult> GetProduct(int id)
        {
            var product =await _context.Products.FirstOrDefaultAsync(x => x.Id == id);
            return Ok(product);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
       [AllowAnonymous]
       [HttpPost("addproduct")]
        public async Task<IActionResult> AddProduct(ProductForAddDto productForAddDto)
        {
         productForAddDto.Name = productForAddDto.Name.ToLower();
         var productToCreate = new Product
         {
            Name = productForAddDto.Name,
            Kcal = productForAddDto.Kcal,
            Protein = productForAddDto.Protein,
            Fat = productForAddDto.Fat,
            Sugar = productForAddDto.Sugar

         };

         var createdProduct = await _repo.AddProduct(productToCreate);
         return StatusCode(201);

        }



    }
}
