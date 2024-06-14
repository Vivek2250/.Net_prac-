using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Milestone3_Exercise1.Data;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<Milestone3_Exercise1Context>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("Milestone3_Exercise1Context") ?? throw new InvalidOperationException("Connection string 'Milestone3_Exercise1Context' not found.")));

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
