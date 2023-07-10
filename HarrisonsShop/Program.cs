//ASP.NET Core with built-in web server(Kestrel)
using HarrisonsShop.Models;

var builder = WebApplication.CreateBuilder(args);

//builder.Services.AddTransient //adds a new instance everytime
//builder.Services.AddSingleton //creates one singleton
builder.Services.AddScoped<ICategoryRepository, MockCategoryRepository>(); //create a sington while a request is being handled, most used
builder.Services.AddScoped<IPieRepository, MockPieRepository>();

builder.Services.AddControllersWithViews();

var app = builder.Build();

app.UseStaticFiles(); //incoming request for static files()jpeg or scc files)

if (app.Environment.IsDevelopment()) // check to see is app is running in dev mode
{
    app.UseDeveloperExceptionPage(); //see errors inside executing application
}

app.MapDefaultControllerRoute(); //set some defualts to route to views that I create. endpoint middleware

app.Run();
