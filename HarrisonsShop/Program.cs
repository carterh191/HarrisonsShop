//ASP.NET Core with built-in web server(Kestrel)
using HarrisonsShop.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

//builder.Services.AddTransient //adds a new instance everytime
//builder.Services.AddSingleton //creates one singleton
builder.Services.AddScoped<ICategoryRepository, CategoryRepository>(); 
builder.Services.AddScoped<IPieRepository, PieRepository>();

//add framework services using extension method
builder.Services.AddDbContext<HarrisonsShopDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration["ConnectionStrings:HarrisonsShopDbContextConnection"]);
});

var app = builder.Build();

app.UseStaticFiles(); //incoming request for static files()jpeg or scc files)

if (app.Environment.IsDevelopment()) // check to see is app is running in dev mode
{
    app.UseDeveloperExceptionPage(); //see errors inside executing application
}

app.MapDefaultControllerRoute(); //set some defualts to route to views that I create. endpoint middleware

app.Run();
