using Capa.Entidades;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.EntityFrameworkCore;
using SchoolMusic.Web.Data;

var builder = WebApplication.CreateBuilder(args);

// Agregar configuraci�n de MailSettings desde appsettings.json
builder.Services.Configure<MailSettings>(builder.Configuration.GetSection("MailSettings"));

// Registrar MailService para la inyecci�n de dependencias
builder.Services.AddScoped<SchoolMusic.Web.Service.MailService>();

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddDbContext<SchoolMusicWebContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("SchoolMusicWebContext")
    ?? throw new InvalidOperationException("Connection string 'SchoolMusicWebContext' not found.")));

builder.Services.AddScoped<ImageService>();

// Configura autenticaci�n basada en cookies
builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
    .AddCookie(options =>
    {
        options.LoginPath = "/Logins/LoginUser"; // P�gina de inicio de sesi�n
        options.AccessDeniedPath = "/AccessDenied"; // P�gina de acceso denegado
    });

var app = builder.Build();

// Elimina cookies de autenticaci�n al inicio de la aplicaci�n
app.Use(async (context, next) =>
{
    if (context.Request.Path == "/") // Opcional: Solo en la ra�z de la aplicaci�n
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

app.UseAuthentication(); // Agregar autenticaci�n
app.UseAuthorization();

app.MapRazorPages();

app.Run();
