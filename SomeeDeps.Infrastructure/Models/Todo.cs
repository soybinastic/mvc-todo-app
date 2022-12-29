namespace SomeeDeps.Infrastructure.Models;


public class Todo 
{
    public int Id { get; set; }
    public string Title { get; set; } = null!;
    public bool IsDone { get; set; }
}