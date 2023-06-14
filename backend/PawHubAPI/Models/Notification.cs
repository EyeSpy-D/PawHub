using System.ComponentModel.DataAnnotations.Schema;

namespace PawHubAPI.Models;

public class Notification
{
    public int NotificationID { get; set; }
        
    public string Text { get; set; }
        
    public DateTime CreatedAt { get; set; }
        
    [ForeignKey("User")]
    public int UserId { get; set; }
        
    public User User { get; set; }
}