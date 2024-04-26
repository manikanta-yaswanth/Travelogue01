using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Travelogue03.Data;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<Travelogue03Context>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("Travelogue03Context") ?? throw new InvalidOperationException("Connection string 'Travelogue03Context' not found.")));

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
