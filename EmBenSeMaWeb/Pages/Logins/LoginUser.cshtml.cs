using Capa.Entidades;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SchoolMusic.Entidades;
using System.Security.Claims;

namespace SchoolMusic.Web.Pages.Logins
{
    public class LoginModel : PageModel
    {
        private readonly SchoolMusic.Web.Data.SchoolMusicWebContext _context;

        public LoginModel(SchoolMusic.Web.Data.SchoolMusicWebContext context)
        {
            _context = context;
        }

        public void OnGet()
        {

        }

        [BindProperty]
        public Users Users { get; set; } = default!;

        public async Task<IActionResult> OnPostAsync()
        {
            var user = await _context.Users
                .FirstOrDefaultAsync(u => u.Username == Users.Username && u.UserPassword == Users.UserPassword);

            if (user != null)
            {
                // Crear los claims de autenticación
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, user.Username),
                    new Claim("UserId", user.IdUser.ToString()),
                    new Claim(ClaimTypes.Role, user.Rol) // Rol: "Profesor" o "Alumno"
                };

                var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);

                // Crear la cookie de autenticación
                await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(claimsIdentity));

                // Redirigir según el rol
                if (user.Rol == "Profesor")
                {
                    return RedirectToPage("/Aula/AulaTeacher");
                }
                else if (user.Rol == "Alumno")
                {
                    return RedirectToPage("/Aula/AulaStudent");
                }
            }

            // Usuario no encontrado o contraseña incorrecta
            ModelState.AddModelError(string.Empty, "Usuario o contraseña incorrectos.");
            return Page();
        }
    }
}
