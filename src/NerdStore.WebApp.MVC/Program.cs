using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using NerdStore.Catalogo.Application.AutoMapper;
using NerdStore.Catalogo.Data;
using NerdStore.WebApp.MVC.Data;
using NerdStore.WebApp.MVC.Setup;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(connectionString));
builder.Services.AddDatabaseDeveloperPageExceptionFilter();

builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<ApplicationDbContext>();

builder.Services.AddDbContext<CatalogoContext>(options =>
    options.UseSqlServer(connectionString));

builder.Services.AddControllersWithViews();

builder.Services.AddAutoMapper(typeof(DomainToViewModelMappingProfile), typeof(ViewModelToDomainMappingProfile));
builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));

builder.Services.RegisterServices();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
}
else
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
app.MapRazorPages();

app.Run();