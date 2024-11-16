using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.EntityFrameworkCore;
using SchoolMusic.Web.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddDbContext<SchoolMusicWebContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("SchoolMusicWebContext")
    ?? throw new InvalidOperationException("Connection string 'SchoolMusicWebContext' not found.")));

builder.Services.AddScoped<ImageService>();

// Configura autenticación basada en cookies
builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
    .AddCookie(options =>
    {
        options.LoginPath = "/Logins/LoginUser"; // Página de inicio de sesión
        options.AccessDeniedPath = "/AccessDenied"; // Página de acceso denegado
    });

var app = builder.Build();

// Elimina cookies de autenticación al inicio de la aplicación
app.Use(async (context, next) =>
{
    if (context.Request.Path == "/") // Opcional: Solo en la raíz de la aplicación
    {
        await context.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
    }
    await next();
});

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication(); // Agregar autenticación
app.UseAuthorization();

app.MapRazorPages();

app.Run();
