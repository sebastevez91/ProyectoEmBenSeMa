using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SchoolMusic.Entidades;
using SchoolMusic.Web.Data;

namespace SchoolMusic.Web.Pages.Login
{
    public class LoginTeacherModel : PageModel
    {
        private readonly SchoolMusic.Web.Data.SchoolMusicWebContext _context;

        public LoginTeacherModel(SchoolMusic.Web.Data.SchoolMusicWebContext context)
        {
            _context = context;
        }
        
        [BindProperty]
        public Users Users { get; set; } = default!;
        public async Task<IActionResult> OnPostAsync()
        {
            var users = await _context.Users.FirstOrDefaultAsync(u => u.Username  == Users.Username
            && u.UserPassword == Users.UserPassword);

            if (users != null)
            {
                // Inicio de sesión exitoso
                
                return RedirectToPage("/Aula/AulaTeacher", new { id = users.IdUser });
            }
            else
            {
                // Usuario no encontrado o contraseña incorrecta
                ModelState.AddModelError(string.Empty, "Usuario o contraseña incorrectos.");
                return Page();
            }
        }
        public void OnGet()
        {
        }
    }
}
