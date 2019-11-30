using System.Threading.Tasks;
using Projekt.API.Models;

namespace Projekt.API.Data
{//wykorzystywane metody przez interfejs 
    public interface IAuthRepository
    {
        Task<User> Register(User user, string password); 
        Task<User> Login(string username, string password);
        Task<bool> UserExists(string username); 

    }
}