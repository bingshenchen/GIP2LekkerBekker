using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using LekkerBek.Data;

/* GroepNr:                 14
 * GroepLid:                Bingshen, Wannes, Yasir, Zjef
 * Date:                    2023/2/27 
 * Version:                 0.5.1
 * Techical consultant:     Artus Vranken
 * Situaction:              Basisfuncties, klaar voor algemeen gebruik, 
 */

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<LekkerBekContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("LekkerBekContext") ?? throw new InvalidOperationException("Connection string 'LekkerBekContext' not found.")));

// Add services to the container.
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
