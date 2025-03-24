
using Kevin20250324.AppWebMVC.Modelos;
using Kevin20250324.AppWebMVC.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<Kevin20250324.AppWebMVC.Modelos.Test20250324DbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("Conn"));
});
builder.Services.AddDbContext<Kevin20250324.AppWebMVC.Models.Test20250324DbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("Conn"));
});

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
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
