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

        public async Task<IActionResult> OnGetAsync()
        {
            var userId = User.FindFirst("UserId")?.Value;

            if (string.IsNullOrEmpty(userId))
            {
                return RedirectToPage("/Logins/LoginUser");
            }

            var teacher = await _context.Teacher
                .Include(t => t.Cursada)
                .FirstOrDefaultAsync(m => m.IdUser == int.Parse(userId));

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
