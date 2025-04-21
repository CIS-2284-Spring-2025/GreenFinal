using System.ComponentModel.DataAnnotations;

public class BlogPost
{
    [Key] // Primary Key
    public int Id { get; set; }
    public string PostTitle { get; set; }
    public string Content { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.Now;
}
