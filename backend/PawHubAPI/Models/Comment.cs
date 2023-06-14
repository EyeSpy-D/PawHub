using System.ComponentModel.DataAnnotations.Schema;

namespace PawHubAPI.Models;

public class Comment
{
    public int CommentID { get; set; }
        
    public string Text { get; set; }
        
    public DateTime CreatedAt { get; set; }
        
    [ForeignKey("User")]
    public int UserId { get; set; }
        
    public User User { get; set; }
        
    [ForeignKey("Question")]
    public int? QuestionId { get; set; }
        
    public Question Question { get; set; }
        
    [ForeignKey("Answer")]
    public int? AnswerId { get; set; }
        
    public Answer Answer { get; set; }
}