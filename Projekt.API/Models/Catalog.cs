using System;

namespace Projekt.API.Models
{
    public class Catalog
    {
        public int Id { get; set; }
        public string Date { get; set; }
        public int ProductWeight { get; set; }
        public User User { get; set; }
        public int UserId { get; set; }
       
    }
}