using System.ComponentModel.DataAnnotations;

namespace Projekt.API.Dtos
{
    public class UserForRegisterDto
    {
      [Required]
      public string Username { get; set; }  


    [Required]
    [StringLength(8, MinimumLength = 4, ErrorMessage = "haslo pomiedzy 4 a 8 znakami")]
    public string Password { get; set; }

    [Required]
    public string Email{ get; set; }

    [Required]
    public int Height { get; set; }

    [Required]
    public int Weight { get; set; }
    }

}