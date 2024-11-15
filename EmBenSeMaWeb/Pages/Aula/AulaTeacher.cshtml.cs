using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SchoolMusic.Entidades;
using SchoolMusic.Web.Data;

namespace SchoolMusic.Web.Pages.Aula
{
    [Authorize(Roles = "Profesor")]
    public class AulaTeacherModel : PageModel
    {
        private readonly SchoolMusicWebContext _context;
        public AulaTeacherModel(SchoolMusicWebContext context)
        {
            _context = context;
        }

        public Teacher Teacher { get; set; } = default!;
        public Users UserSesion { get; set; }
        public IList<Cursada> Cursada { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Teacher == null)
            {
                return NotFound();
            }
            var user = await _context.Users.FirstOrDefaultAsync(u => u.IdUser == id);
            if (user != null)
            {
                UserSesion = user;
            }

            var teacher = await _context.Teacher.FirstOrDefaultAsync(m => m.IdUser == id);
            var cursadas = await _context.Cursada
                .Where(c => c.IdTeacher == teacher.IdTeacher)
                .ToListAsync();

            if (teacher == null)
            {
                return NotFound();
            }
            else
            {
                Teacher = teacher;
                Cursada = cursadas;
            }
            return Page();
        }
    }
}
