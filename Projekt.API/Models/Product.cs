using System.Collections.Generic;

namespace Projekt.API.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Kcal { get; set; }
        public int Protein { get; set; }
        public int Fat { get; set; }
        public int Sugar { get; set; }
        public ICollection<Catalog> Catalogs { get; set; }
    }
}