using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using day21_calculator.Data;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<day21_calculatorContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("day21_calculatorContext") ?? throw new InvalidOperationException("Connection string 'day21_calculatorContext' not found.")));

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
