using Microsoft.EntityFrameworkCore;
using TrabalhoFinal.DataBase;
using TrabalhoFinal.Repositorio;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<BaseDadosContext>(opc => opc.UseSqlServer("Data Source=DESKTOP-V534R0G;Initial Catalog=master;Integrated Security=True"));
builder.Services.AddScoped<iDBRepositorio, BaseDadosRepositorio>();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    
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
