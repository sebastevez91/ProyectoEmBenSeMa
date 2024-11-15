using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SchoolMusic.Entidades;

namespace SchoolMusic.Web.Pages.Logins
{
    public class RegisterModel : PageModel
    {
        private readonly SchoolMusic.Web.Data.SchoolMusicWebContext _context;
        public RegisterModel(SchoolMusic.Web.Data.SchoolMusicWebContext context)
        {
            _context = context;
        }
        public void OnGet()
        {
        }

        [BindProperty]
        public Users Users { get; set; } 
        [BindProperty]
        public string rePassword { get; set; } = default!;
        [BindProperty]
        public Teacher Teacher {  get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid || _context.Users == null || Users == null)
            {
                return Page();
            }

            // Verificar si las contraseñas coinciden
            if (Users.UserPassword != rePassword)
            {
                ModelState.AddModelError(string.Empty, "Las contraseñas ingresadas no son idénticas");
                return Page();
            }

            // Agregar el usuario y guardar los cambios
            _context.Users.Add(Users);
            await _context.SaveChangesAsync();

            if(Users.Rol == "Profesor")
            {
                return RedirectToPage("/Teachers/Create", new { id = Users?.IdUser });
            }
            if(Users.Rol == "Alumno")
            {
                return RedirectToPage("/Students/Create", new { id = Users?.IdUser });
            }
            return Page();
        }
    }
}
