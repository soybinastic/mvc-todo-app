namespace SomeeDeps.Web.Models;

public class TodoViewModel
{
    public int Id { get; set; }
    public string Title { get; set; } = null!;
    public bool IsDone { get; set; }
}