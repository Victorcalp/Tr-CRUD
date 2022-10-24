using Microsoft.EntityFrameworkCore;
using Treinando_Crud.DataBase;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

//Conex�o com Banco de Dados
builder.Services.AddDbContext<Context>(context => context.UseMySql("server = localhost; initial catalog = Treinando_CRUD; uid=developer; pwd=Victorc@lp0609", Microsoft.EntityFrameworkCore.ServerVersion.Parse("8.0.31 - mysql")));

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
