

using Microsoft.EntityFrameworkCore;
using asp_crud.Data;

public static class DataMigrations {
  public static void MigrateDb(this WebApplication app){
    using var scope = app.Services.CreateScope();
    var dbContext = scope.ServiceProvider.GetRequiredService<TodoContext>();
    dbContext.Database.Migrate();
  }
}
