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
    }

}