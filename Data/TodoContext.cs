using asp_crud.Entities;
using Microsoft.EntityFrameworkCore;

namespace asp_crud.Data;

public class TodoContext:DbContext {

  public TodoContext(DbContextOptions<TodoContext> opt):base(opt){

  }
  public DbSet<TodoEntity> Todos => Set<TodoEntity>();
}
