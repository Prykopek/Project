using System.ComponentModel.DataAnnotations;

namespace Projekt.API.Dtos
{
    public class ProductForAddDto
    {
      
    [Required]
    public string Name { get; set; }  
    
    [Required]
    public int Kcal { get; set; }

    [Required]
    public int Protein { get; set; }

    [Required]
    public int Fat { get; set; }

    [Required]
    public int Sugar { get; set; }
        
    }  
    }
