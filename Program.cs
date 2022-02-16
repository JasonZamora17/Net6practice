using Microsoft.EntityFrameworkCore;
using Net6Tut.Models;

var builder = WebApplication.CreateBuilder(args);

var connectionString = "server=localhost;userid=root;password=root;port=3306;database=Net6Tut;SslMode=None";
var serverVersion = new MySqlServerVersion(new Version(8, 0, 27));

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<Net6TutDbContext>(
    dbContextOptions => dbContextOptions
        .UseMySql(connectionString, serverVersion));
builder.Services.AddHttpContextAccessor();
builder.Services.AddSession();
builder.Services.AddMvc(options => options.EnableEndpointRouting = false);


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
app.UseSession();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
