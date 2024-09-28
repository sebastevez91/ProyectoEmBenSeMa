using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SchoolMusic.Entidades;

namespace SchoolMusic.Web.Pages.Teachers
{
    public class EditModel : PageModel
    {
        private readonly SchoolMusic.Web.Data.SchoolMusicWebContext _context;

        public EditModel(SchoolMusic.Web.Data.SchoolMusicWebContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Teacher Teacher { get; set; } = default!;
        public string AlertMessage { get; set; }
        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Teacher == null)
            {
                return NotFound();
            }

            var teacher = await _context.Teacher.FirstOrDefaultAsync(m => m.IdTeacher == id);
            if (teacher == null)
            {
                return NotFound();
            }
            Teacher = teacher;
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Teacher).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TeacherExists(Teacher.IdTeacher))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            AlertMessage = "Perfil actualizado";

            return RedirectToPage("/Aula/AulaTeacher", new { id = Teacher?.IdUser });
        }

        private bool TeacherExists(int id)
        {
            return (_context.Teacher?.Any(e => e.IdTeacher == id)).GetValueOrDefault();
        }
    }
}
