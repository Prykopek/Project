using System.Threading.Tasks;
using Projekt.API.Models;

namespace Projekt.API.Data
{
    public interface IProductRepository
    {
        Task<Product> AddProduct(Product product); 
         
    }
}