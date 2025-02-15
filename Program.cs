using Microsoft.EntityFrameworkCore;
using StoreApp2.Data.Concrete.EfCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<IdentityContext>(options =>{
    options.UseSqlite(builder.Configuration.GetConnectionString("sql_connection"));
});



var app = builder.Build();
app.UseRouting();
app.UseAuthentication();
app.UseAuthorization();
app.UseHttpsRedirection();
app.UseStaticFiles();

app.MapControllerRoute(
    name:"default",
    pattern:"{controller=Home}/{action=Index}/{id?}"
);


app.Run();
