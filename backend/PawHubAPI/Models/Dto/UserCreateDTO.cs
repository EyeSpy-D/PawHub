using System.ComponentModel.DataAnnotations;

namespace PawHubAPI.Models.Dto;

public class UserCreateDTO
{
    [Required]
    [MaxLength(30)]
    public string Email { get; set; }
    
    public string Password { get; set; }
}