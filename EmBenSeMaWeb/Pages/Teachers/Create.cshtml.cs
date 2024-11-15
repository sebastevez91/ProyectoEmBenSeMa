using CloudinaryDotNet.Actions;
using CloudinaryDotNet;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SchoolMusic.Entidades;
using SchoolMusic.Serv;

namespace SchoolMusic.Web.Pages.Teachers
{
    public class CreateModel : PageModel
    {
        private readonly SchoolMusic.Web.Data.SchoolMusicWebContext _context;

        public CreateModel(SchoolMusic.Web.Data.SchoolMusicWebContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }


        [BindProperty]
        public Teacher Teacher { get; set; } = default!;

        [BindProperty]
        public Users Users { get; set; } = default!;

        [BindProperty]
        public string rePassword { get; set; } = default!;

        public string confirmacionRegistro = ""; 

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid || _context.Teacher == null || Teacher == null)
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

            // Obtener el Id del usuario recién creado
            Teacher.IdUser = Users.IdUser;
            _context.Teacher.Add(Teacher);
            await _context.SaveChangesAsync();

            confirmacionRegistro = "Registro exitoso";

            return RedirectToPage("./Index");
        }
    }
}
