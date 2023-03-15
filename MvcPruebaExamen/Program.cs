using Microsoft.EntityFrameworkCore;
using MvcPruebaExamen.Data;
using MvcPruebaExamen.Helpers;
using MvcPruebaExamen.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
string connectionString =
    builder.Configuration.GetConnectionString("SqlHospital");
builder.Services.AddTransient<RepositoryUsuarios>();
builder.Services.AddTransient<RepositoryHospital>();
builder.Services.AddDbContext<UsuariosContext>
    (options => options.UseSqlServer(connectionString));
builder.Services.AddDbContext<HospitalContext>
    (options => options.UseSqlServer(connectionString));
builder.Services.AddControllersWithViews();

builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromMinutes(30);
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

app.UseSession();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
