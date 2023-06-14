using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PawHubAPI.Models;

public class Question
{
    public int QuestionID { get; set; }
    
    [Required]
    public string Title { get; set; }
    
    public string Text { get; set; }
    
    [ForeignKey("User")]
    public int UserId { get; set; }
    
    public User User { get; set; }

    public DateTime CreateDateTime { get; set; } = DateTime.Now;
}