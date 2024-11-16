using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SchoolMusic.Entidades;
using SchoolMusic.Web.Data;

namespace SchoolMusic.Web.Pages.Aula
{
    [Authorize(Roles = "Alumno")]
    public class AulaStudentModel : PageModel
    {
        private readonly SchoolMusicWebContext _context;
        public AulaStudentModel(SchoolMusicWebContext context)
        {
            _context = context;
        }
        public Student Student { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync()
        {
            var userId = User.FindFirst("UserId")?.Value;

            if (string.IsNullOrEmpty(userId))
            {
                return RedirectToPage("/Logins/LoginUser");
            }

            var student = await _context.Student
                .Include(i => i.Inscriptions)
                .FirstOrDefaultAsync(m => m.IdUser == int.Parse(userId));
            if (student == null)
            {
                return NotFound();
            }
            Student = student;

            return Page();

        }

    }
}
