
using Microsoft.EntityFrameworkCore;
using NoticiasWeb.Data;
using NoticiasWeb.Repository;
using NoticiasWeb.Models;
using NoticiasWeb.Service;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();



builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<ApplicationDBContext>(options =>
options.UseSqlServer("Server=LUISBY860\\SQLEXPRESS;Database=NoticiasWeb; TrustServerCertificate=true; Trusted_Connection=true; Connection Timeout= 30; Integrated Security=true; Persist Security Info= false; Encrypt= true; MultipleActiveResultSets=true;")

);

builder.Services.AddTransient<ICategoria,Categoria>();
builder.Services.AddTransient<ISuscripcion, Suscripciones>();
builder.Services.AddTransient<IPrivilegio, Privilegio>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Categoria}/{action=Index}/{id?}");

app.Run();
