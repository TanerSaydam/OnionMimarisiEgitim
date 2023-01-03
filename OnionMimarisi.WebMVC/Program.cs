using MediatR;
using Microsoft.EntityFrameworkCore;
using OnionMimarisi.Application;
using OnionMimarisi.Domain.Entities.Identity;
using OnionMimarisi.Persistance;
using OnionMimarisi.Persistance.Context;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

#region DbContext
builder.Services.AddDbContext<ApplicationDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("SqlServer"));
});
builder.Services.AddIdentity<AppUser, AppRole>(options =>
{
    options.Password.RequiredLength = 1;
    options.User.RequireUniqueEmail = true;
}).AddEntityFrameworkStores<ApplicationDbContext>();
#endregion


#region ServiceRegistration
builder.Services.AddApplicationService();
builder.Services.AddPersistanceService();
#endregion


builder.Services.AddControllersWithViews();

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
