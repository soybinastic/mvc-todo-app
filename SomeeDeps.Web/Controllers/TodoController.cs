using Microsoft.AspNetCore.Mvc;
using SomeeDeps.Application.Contracts;
using SomeeDeps.Infrastructure.Models;
using SomeeDeps.Web.Models;
using SomeeDeps.Web.Models.Dto;

namespace SomeeDeps.Web.Controllers;

public class TodoController : Controller
{
    private readonly ITodoService _todoService;
    public TodoController(ITodoService todoService)
    {
        _todoService = todoService;
    }

    public async Task<IActionResult> Index()
    {
        var todos = (await _todoService.GetAll()).Select(t => new TodoViewModel { Id = t.Id, Title = t.Title, IsDone = t.IsDone });
        return View(todos);
    }

    [HttpPost]
    public async Task<IActionResult> Update(int id)
    {
        var todo = await _todoService.Get(id);
        if(todo is null) return RedirectToAction("Index");

        todo.IsDone = !todo.IsDone;
        await _todoService.Update(todo);
        return RedirectToAction("Index");
    }

    public IActionResult Create()
    {
        return View(new CreateTodoDto());
    }

    [HttpPost]
    public async Task<IActionResult> Create(CreateTodoDto createTodoDto)
    {
        if(!ModelState.IsValid) return View(createTodoDto);

        await _todoService.Create(
            new Todo { Title = createTodoDto.Title });
        
        return RedirectToAction("Index");
    }
}