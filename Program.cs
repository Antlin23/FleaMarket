using FleaMarket.Contexts;
using FleaMarket.Models.ViewModels;
using FleaMarket.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<DataContext>(x => x.UseSqlServer(builder.Configuration.GetConnectionString("sql")));

builder.Services.AddScoped<ProductService>();



var app = builder.Build();
app.UseHsts();
//redirect from http to https
app.UseHttpsRedirection();
//use static files as pictures
app.UseStaticFiles();
//routing betweeen controllers
app.UseRouting();
app.UseAuthorization();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
app.Run();
