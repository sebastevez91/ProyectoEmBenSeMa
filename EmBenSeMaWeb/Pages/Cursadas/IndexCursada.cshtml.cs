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
        public Inscription Inscription { get; set; } = new Inscription();

        public async Task OnGetAsync(int? idCourse)
        {
            if (idCourse != null &&  _context.Cursada != null)
            {
                Cursada = await _context.Cursada
                    .Where(c => c.IdCourse == idCourse)
                    .Include(cou => cou.Course).ToListAsync();
            }
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid || _context.Inscription == null || Inscription == null)
            {
                return Page();
            }

            var userId = User.FindFirst("UserId")?.Value;

            if (string.IsNullOrEmpty(userId))
            {
                return RedirectToPage("/Logins/LoginUser");
            }

            var student = await _context.Student.FirstOrDefaultAsync(m => m.IdUser == int.Parse(userId));
            if (student == null)
            {
                return Page();
            }
            Inscription.idStudent = student.IdStudent;
            _context.Inscription.Add(Inscription);
            await _context.SaveChangesAsync();

            return RedirectToPage("/Aula/AulaStudent");
        }
    }
}
