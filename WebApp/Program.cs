var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();

var app = builder.Build();
app.UseHsts();

// Omvandlar http till https 
app.UseHttpsRedirection();
// wwwroot
app.UseStaticFiles();
// Routing, hur det kopplas ihop + funktionalitet
app.UseRouting();
// Säkra upp sidor, tex. måste vara inloggad för att se en viss sida
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
