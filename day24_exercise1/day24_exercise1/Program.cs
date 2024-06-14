using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using day24_exercise1.Data;
using day24_exercise1.Models;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<day24_exercise1Context>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("day24_exercise1Context") ?? throw new InvalidOperationException("Connection string 'day24_exercise1Context' not found.")));

// Add services to the container.
builder.Services.AddTransient<IUser, UserDetails>();
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

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
