
using Microsoft.EntityFrameworkCore;
using asp_crud.Data;
using Npgsql.EntityFrameworkCore.PostgreSQL;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<TodoContext>(options => options.UseNpgsql(builder.Configuration.GetConnectionString("PostgresqlServer")));

builder.Services.AddControllers();

var app = builder.Build();
app.MapControllers();
app.Run();
