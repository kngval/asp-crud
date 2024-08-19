namespace asp_crud.Entities;

public class TodoEntity {
  public int Id {get;set;}
  public required string Title {get;set;}
  public required string Todo {get;set;}
  public DateOnly Deadline {get;set;}
}
