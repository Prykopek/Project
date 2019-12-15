using Microsoft.EntityFrameworkCore;
using Projekt.API.Models;

namespace Projekt.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options){}
        
        public DbSet<Value> Values { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Catalog> Catalogs { get; set; }
        public DbSet<Product> Products { get; set; }
        
        
        protected override void OnModelCreating(ModelBuilder builder)
        {
            
        }
    }
}