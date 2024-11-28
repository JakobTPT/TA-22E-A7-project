using AsixEvents.Data;
using Microsoft.EntityFrameworkCore;
using AsixEvents.Data;  // Namespace for ApplicationDbContext

var builder = WebApplication.CreateBuilder(args);

// Configure the DbContext to use SQLite
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection")));  // Use connection string

// Register other services
builder.Services.AddControllersWithViews();

var app = builder.Build();

// HTTP request pipeline (middleware)
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}
else
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
