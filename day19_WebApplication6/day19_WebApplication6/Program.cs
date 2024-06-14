using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using day19_WebApplication6.Data;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<day19_WebApplication6Context>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("day19_WebApplication6Context") ?? throw new InvalidOperationException("Connection string 'day19_WebApplication6Context' not found.")));

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
