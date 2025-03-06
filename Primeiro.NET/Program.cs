using Microsoft.EntityFrameworkCore;

using PrimeiroDOTNET.Data;
using PrimeiroDOTNET.Services;

var builder = WebApplication.CreateBuilder(args);


var services = builder.Services;
var configuration = builder.Configuration;

var connectionString = configuration.GetConnectionString("NomeDoProjeto");

services.AddDbContext<PrimeiroDOTNETContext>(options =>
{
    options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
});

// Registra sistema da aplicação seeding
services.AddScoped<SeedingService>();
services.AddScoped<SellerService>();
services.AddScoped<DepartamentService>();



builder.Services.AddControllersWithViews();
// Add services to the container.
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{

    app.UseExceptionHandler("/Home/Error");


    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
else
{   // <-- este bloco inteiro de else
    using (var scope = app.Services.CreateScope())
    {
        var service = scope.ServiceProvider;
        var context = service.GetRequiredService<PrimeiroDOTNETContext>();
        var seedingService = new SeedingService(context);
        seedingService.Seed();
    }
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
