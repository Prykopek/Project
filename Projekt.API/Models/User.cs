using System;
using System.Collections.Generic;

namespace Projekt.API.Models
{
    public class User
    {
       public int Id { get; set; } 
       public string Username { get; set; }
       public byte[] PasswordHash { get; set; }
       public byte[] PasswordSalt { get; set; }
       public int Height { get; set; }
       public int Weight { get; set; }
       public DateTime Created { get; set; }
       public DateTime DateOfBirth { get; set; }
       public string Gender { get; set; }
       public string City { get; set; }
       public string Email { get; set; }
       public ICollection <Catalog> Catalogs { get; set; }

    }
}