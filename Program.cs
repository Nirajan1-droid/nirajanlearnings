using Microsoft.AspNetCore.Mvc;
 
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.MapControllerRoute(
    name: "new",
    pattern: "new",
    defaults: new { controller = "New", action = "Index" }); // Assuming you have a NewController with an Index action
app.MapControllerRoute(
    name: "account",
    pattern: "account",
    defaults: new { controller = "Account", action = "Index" }); // Assuming you have a AccountController with an Index action
app.MapControllerRoute(
    name: "account/login",
    pattern: "account/login",
    defaults: new { controller = "Account", action = "Index" });
app.Run();
