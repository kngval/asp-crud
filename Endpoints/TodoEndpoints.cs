
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using asp_crud.Data;
using asp_crud.Entities;
namespace asp_crud.Endpoints;


[ApiController]
[Route("/todo")]
public class TodoEndpoints : ControllerBase
{
    private readonly TodoContext todoContext;

    public TodoEndpoints(TodoContext _context)
    {
        todoContext = _context;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<TodoEntity>>> GetTodos()
    {
        var todos = await todoContext.Todos.ToListAsync();
        return Ok(todos);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<TodoEntity>> GetTodoById(int id){
      var todo = await todoContext.Todos.FindAsync(id);
      if(todo is null){
        return NotFound();
      }
      return todo;
    }


    [HttpPost]
   public async Task<ActionResult<TodoEntity>>CreateTodo(TodoEntity todo){
     todoContext.Todos.Add(todo);
     await todoContext.SaveChangesAsync();
     return CreatedAtAction(nameof(GetTodoById), new { id = todo.Id },todo);
   } 

}


