using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SchoolMusic.Entidades;
using SchoolMusic.Web.Data;

namespace SchoolMusic.Web.Pages.Aula
{
    public class AulaTeacherModel : PageModel
    {
        private readonly SchoolMusicWebContext _context;
        public AulaTeacherModel(SchoolMusicWebContext context)
        {
            _context = context;
        }

        public Teacher Teacher { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Teacher == null)
            {
                return NotFound();
            }

            var teacher = await _context.Teacher.Include(c => c.Cursada)
                                .FirstOrDefaultAsync(m => m.IdUser == id);
            if (teacher == null)
            {
                return NotFound();
            }
            else
            {
                Teacher = teacher;
            }
            return Page();
        }
    }
}
