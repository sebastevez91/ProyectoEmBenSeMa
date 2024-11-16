using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SchoolMusic.Entidades;

namespace SchoolMusic.Web.Pages.Cursadas
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
        public Cursada Cursada { get; set; } = new Cursada();

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid || _context.Cursada == null || Cursada == null)
            {
                return Page();
            }

            var userId = User.FindFirst("UserId")?.Value;

            if (string.IsNullOrEmpty(userId))
            {
                return RedirectToPage("/Logins/LoginUser");
            }

            var teacher = await _context.Teacher.FirstOrDefaultAsync(m => m.IdUser == int.Parse(userId));
            if (teacher == null)
            {
                return NotFound();
            }
            Cursada.IdTeacher = teacher.IdTeacher;

            _context.Cursada.Add(Cursada);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Details");
        }
    }
}
