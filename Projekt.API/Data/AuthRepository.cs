using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Projekt.API.Models;

namespace Projekt.API.Data
{
    public class AuthRepository : IAuthRepository
    {
        // dzięki temu mamy dostęp do context w IAuthRepository
        private readonly DataContext _context;

        public AuthRepository(DataContext context)
        {
            _context = context;
        }
        public async Task<User> Login(string username, string password)
        {
           var user = await _context.Users.FirstOrDefaultAsync(x => x.Username == username); // pzreszukuje username, jak nie ma takiego zwraca null dzięki FirstorDefault

           if (user == null)
                return null;

           if (!VerifyPasswordHash(password, user.PasswordHash, user.PasswordSalt))
                return null;

                return user;
        }

        private bool VerifyPasswordHash(string password, byte[] passwordHash, byte[] passwordSalt)
        {
            using (var hmac = new System.Security.Cryptography.HMACSHA512(passwordSalt))
            {
                var computedHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
                for (int i =0; i < computedHash.Length; i++)
                {
                    if(computedHash[i] != passwordHash[i]) return false; // jezeli są takie same zwroci true
                }
            }
            return true;
        }

        public async Task<User> Register(User user, string password)
        {
           byte[] passwordHash, passwordSalt;
           // nie chcemy przesyłać wartosci passHash i passSalt tylko reference, dlatego out
           CreatePasswordHash(password, out passwordHash, out passwordSalt);

           user.PasswordHash = passwordHash;
           user.PasswordSalt = passwordSalt;

           await _context.Users.AddAsync(user);
           await _context.SaveChangesAsync();

           return user;
        }

        private void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt)
        {
            // dzieki using tworzymy nowa instancję klasy, uzywana przy idisposable object
            using (var hmac = new System.Security.Cryptography.HMACSHA512())
            {
                passwordSalt = hmac.Key; // randomowy key
                passwordHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password)); // password jest stringiem dlatego musimy przerobic na byte, stworzenie ciagu hash(compute hash)
            }
            
        }

        public async Task<bool> UserExists(string username)
        {
        if (await _context.Users.AnyAsync(x => x.Username == username)) // sprawdzamy czy jest jakikolwiek taki user 
            return true;

        return false;    
        }
    }
}