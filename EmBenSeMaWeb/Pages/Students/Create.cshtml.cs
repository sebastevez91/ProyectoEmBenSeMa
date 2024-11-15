using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SchoolMusic.Entidades;

namespace SchoolMusic.Web.Pages.Students
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
        public Student Student { get; set; } = default!;

        [BindProperty]
        public Users Users { get; set; } = default!;

        [BindProperty]
        public string rePassword { get; set; } = default!;

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid || _context.Student == null || Student == null)
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

            Student.IdUser = Users.IdUser;
            _context.Student.Add(Student);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
