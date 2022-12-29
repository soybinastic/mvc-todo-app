using Microsoft.EntityFrameworkCore;
using SomeeDeps.Application.Contracts;
using SomeeDeps.Infrastructure.Data;
using SomeeDeps.Infrastructure.Models;

namespace SomeeDeps.Application.Service;

public class TodoService : ITodoService
{
    private readonly SomeeDepsContext _db;
    public TodoService(SomeeDepsContext db)
    {
        _db = db;
    }
    public async Task<Todo> Create(Todo newTodo)
    {
        await _db.Todos.AddAsync(newTodo);
        await _db.SaveChangesAsync();
        return newTodo;
    }

    public async Task Delete(int id)
    {
        var todoToDelete = await Get(id);
        if(todoToDelete is null) return;

        _db.Todos.Remove(todoToDelete);
        await _db.SaveChangesAsync();
    }

    public async Task<Todo?> Get(int id)
    {
        return await _db.Todos.FirstOrDefaultAsync(t => t.Id == id);
    }

    public async Task<IEnumerable<Todo>> GetAll()
    {
        return await _db.Todos.ToListAsync();
    }

    public async Task<Todo> Update(Todo updatedTodo)
    {
        _db.Todos.Update(updatedTodo);
        await _db.SaveChangesAsync();

        return updatedTodo;
    }
}