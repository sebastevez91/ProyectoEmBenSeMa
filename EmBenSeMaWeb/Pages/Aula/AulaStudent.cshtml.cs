using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SchoolMusic.Entidades;
using SchoolMusic.Web.Data;

namespace SchoolMusic.Web.Pages.Aula
{
    public class AulaStudentModel : PageModel
    {
        private readonly SchoolMusicWebContext _context;
        public AulaStudentModel(SchoolMusicWebContext context)
        {
            _context = context;
        }
        public Student Student { get; set; } = default!;
        public string Username {  get; set; }
        public IList<Inscription> Inscriptions { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Student == null)
            {
                return NotFound();
            }

            var user = await _context.Users.FirstOrDefaultAsync(u => u.IdUser == id);
            if (user != null)
            {
                Username = user.Username;
            }
            var student = await _context.Student.FirstOrDefaultAsync(m => m.IdUser == id);
            if (student == null)
            {
                return NotFound();
            }
            else
            {
                Student = student;
                Inscriptions = await _context.Inscription
                    .Include(c => c.Cursada)
                    .Where(s => s.idStudent == Student.IdStudent)
                    .ToListAsync();
            }
            return Page();

        }

    }
}
