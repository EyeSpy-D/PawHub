using System.ComponentModel.DataAnnotations;

namespace PawHubAPI.Models.Dto;

public class UserUpdateDTO
{
    [Required]
    public int Id { get; set; }
    
    [Required]
    [MaxLength(30)]
    public string Email { get; set; }
    
    [Required]
    public string Password { get; set; }
}