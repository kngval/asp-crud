using Microsoft.EntityFrameworkCore;
using asp_crud.Entities;

public class TodoContext:DbContext {

  public TodoContext(DbContextOptions<TodoContext> opt):base(opt){

  }
  public DbSet<TodoEntity> Todos => Set<TodoEntity>();
}
