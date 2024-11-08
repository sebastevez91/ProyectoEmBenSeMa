using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SchoolMusic.Entidades;

namespace SchoolMusic.Web.Pages.Cursadas
{
    public class DetailsModel : PageModel
    {
        private readonly SchoolMusic.Web.Data.SchoolMusicWebContext _context;

        public DetailsModel(SchoolMusic.Web.Data.SchoolMusicWebContext context)
        {
            _context = context;
        }

        public IList<Cursada> Cursadas { get; set; } = default!;
        public Course? Course { get; set; }
        public int? idTeacher { get; set; }
        public int? idUserSesion { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Cursada == null)
            {
                return NotFound();
            }

            Cursadas = await _context.Cursada
                .Include(t => t.Teacher)
                .Include(c => c.Course)
                .Where(c => c.IdTeacher == id)
                .ToListAsync();
            if (Cursadas == null || Cursadas.Count == 0)
            {
                var teacherSesion = await _context.Teacher.FirstOrDefaultAsync(t => t.IdTeacher == id);
                // Almaceno el ID del usuario en sesión 
                idUserSesion = teacherSesion.IdUser;
                return Page(); // Si no hay Cursadas asociadas, devolver NotFound
            }
            else
            {
                // Almaceno el curso.
                Course = Cursadas[1].Course;
                // Almaceno id de Teacher
                idTeacher = Cursadas[1].IdTeacher;
                // Almaceno el ID del usuario en sesión 
                idUserSesion = Cursadas[0].Teacher.IdUser;
            }


            return Page();
        }
    }
}
