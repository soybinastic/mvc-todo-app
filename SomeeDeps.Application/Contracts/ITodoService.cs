using SomeeDeps.Infrastructure.Models;

namespace SomeeDeps.Application.Contracts;

public interface ITodoService
{
    Task<Todo> Create(Todo newTodo);
    Task<IEnumerable<Todo>> GetAll();

    Task<Todo?> Get(int id);
    Task<Todo> Update(Todo updatedTodo);
    Task Delete(int id);
}