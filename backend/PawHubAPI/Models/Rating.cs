using System.ComponentModel.DataAnnotations.Schema;

namespace PawHubAPI.Models;

public class Rating
{
    public int RatingID { get; set; }
        
    [ForeignKey("User")]
    public int UserId { get; set; }
        
    public User User { get; set; }
        
    [ForeignKey("Answer")]
    public int AnswerId { get; set; }
        
    public Answer Answer { get; set; }
        
    public int Value { get; set; }
}