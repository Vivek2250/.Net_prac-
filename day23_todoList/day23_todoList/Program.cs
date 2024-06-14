using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using day23_todoList.Data;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<day23_todoListContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("day23_todoListContext") ?? throw new InvalidOperationException("Connection string 'day23_todoListContext' not found.")));

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
