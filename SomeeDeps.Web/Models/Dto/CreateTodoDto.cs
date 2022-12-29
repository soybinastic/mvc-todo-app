using System.ComponentModel.DataAnnotations;

namespace SomeeDeps.Web.Models.Dto;

public class CreateTodoDto
{
    [Required(ErrorMessage = "Please put some title of your todo.")]
    public string Title { get; set; } = null!;
}