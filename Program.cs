using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using StoreApp2.Data.Abstract;
using StoreApp2.Data.Concrete.EfCore;
using StoreApp2.Entity;
using StoreApp2.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<IEmailSender,SmtpEmailSender>(i=>
    new SmtpEmailSender(
        builder.Configuration["EmailSender:Host"],
        builder.Configuration.GetValue<int>("EmailSender:Port"),
        builder.Configuration.GetValue<bool>("EmailSender:EnableSSL"),
        builder.Configuration["EmailSender:Username"],
        builder.Configuration["EmailSender:Password"]
    )
);

builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<IdentityContext>(options =>{
    options.UseSqlite(builder.Configuration.GetConnectionString("sql_connection"));
});


builder.Services.Configure<IdentityOptions>(options=>{
    options.Password.RequireLowercase = false;
    options.Password.RequireUppercase = false;
    options.Password.RequiredLength = 6;
    options.Password.RequireNonAlphanumeric = false;  
    options.User.RequireUniqueEmail = true;  
    options.SignIn.RequireConfirmedEmail = true;
});

builder.Services.ConfigureApplicationCookie(options =>{
    options.LoginPath = "/Account/Login"; 

    //  options.SlidingExpiration = true;
    // options.ExpireTimeSpan = TimeSpan.FromDays(30);      // 30 gün boyunca hesap açık kalır
});


builder.Services.AddScoped<IProductRepository,EfProductRepository>();
builder.Services.AddScoped<ICategoryRepository,EfCategorRepository>();

builder.Services.AddIdentity<ApplicationUser,IdentityRole>().AddEntityFrameworkStores<IdentityContext>().AddDefaultTokenProviders();

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
