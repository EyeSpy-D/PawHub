using System.ComponentModel.DataAnnotations.Schema;

namespace PawHubAPI.Models;

public class Answer
{
    public int AnswerID { get; set; }
        
    public string Text { get; set; }
        
    public DateTime CreatedAt { get; set; }
        
    [ForeignKey("User")]
    public int UserId { get; set; }
        
    public User User { get; set; }
        
    [ForeignKey("Question")]
    public int QuestionToAnswerID { get; set; }
        
    public Question Question { get; set; }
}