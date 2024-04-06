using FleaMarket.Contexts;
using FleaMarket.Models.Entities;
using FleaMarket.Models.ViewModels;
using FleaMarket.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<DataContext>(x => x.UseSqlServer(builder.Configuration.GetConnectionString("sql")));

builder.Services.AddIdentity<UserEntity, IdentityRole>( x =>
{
    x.SignIn.RequireConfirmedAccount = true;
    x.User.RequireUniqueEmail = true;
    x.Password.RequiredLength = 6;
}).AddEntityFrameworkStores<DataContext>()
    .AddClaimsPrincipalFactory<CustomClaimsPrincipalFactory>()
     .AddDefaultTokenProviders();

builder.Services.ConfigureApplicationCookie(x =>
{
    x.LoginPath = "/Authentication/LoginUser";
    x.AccessDeniedPath = "/denied";
});

builder.Services.AddScoped<ProductService>();
builder.Services.AddScoped<AuthenticationService>();
builder.Services.AddScoped<UserService>();
builder.Services.AddScoped<MarketService>();
builder.Services.AddScoped<SwishAPIService>();
builder.Services.AddSingleton<SwishAPIService>();
builder.Services.AddScoped<SendGridService>();





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
