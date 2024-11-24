using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SchoolMusic.Entidades;

namespace SchoolMusic.Web.Pages.Cursadas
{
    public class IndexModel : PageModel
    {
        private readonly SchoolMusic.Web.Data.SchoolMusicWebContext _context;

        public IndexModel(SchoolMusic.Web.Data.SchoolMusicWebContext context)
        {
            _context = context;
        }

        public IList<Cursada> Cursada { get; set; } = default!;
        public Student Student { get; set; }
        public Users UserSesion {  get; set; }
        public int? IdUser {  get; set; }
        [BindProperty]
        public int? IdCourse {  get; set; }
        [BindProperty]
        public Inscription Inscription { get; set; } = new Inscription();

        public async Task OnGetAsync(int? idCourse)
        {
            if (idCourse != null &&  _context.Cursada != null)
            {
                Cursada = await _context.Cursada
                    .Where(c => c.IdCourse == idCourse)
                    .Include(c => c.Inscriptions)
                    .Include(cou => cou.Course).ToListAsync();
            }
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid || _context.Inscription == null || Inscription == null)
            {
                return Page();
            }

            // Obtener el ID del usuario actual
            var userId = User.FindFirst("UserId")?.Value;

            if (string.IsNullOrEmpty(userId))
            {
                return RedirectToPage("/Logins/LoginUser");
            }

            // Obtener el estudiante asociado al usuario actual
            var student = await _context.Student.FirstOrDefaultAsync(m => m.IdUser == int.Parse(userId));
            if (student == null)
            {
                return Page();
            }

            // Validar si el estudiante ya está inscrito en la cursada
            var alreadyEnrolled = await _context.Inscription
                .AnyAsync(i => i.idStudent == student.IdStudent && i.idCursada == Inscription.idCursada);

            if (alreadyEnrolled)
            {
                // Mostrar un mensaje de error si ya está inscrito
                TempData["ErrorMessage"] = "Ya estás inscrito en esta cursada.";
                return RedirectToPage("/Cursadas/IndexCursada", new { idCourse = IdCourse });
            }

            // Si no está inscrito, agregar la inscripción
            Inscription.idStudent = student.IdStudent;
            _context.Inscription.Add(Inscription);
            await _context.SaveChangesAsync();

            // Redirigir al aula del estudiante
            TempData["Message"] = "Inscripción realizada con éxito.";
            return RedirectToPage("/Aula/AulaStudent");
        }
    }
}
