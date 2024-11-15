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

        public async Task OnGetAsync(int? idCourse,int? idUser)
        {
            if (idCourse != null &&  _context.Cursada != null)
            {
                Cursada = await _context.Cursada
                    .Where(c => c.IdCourse == idCourse)
                    .Include(cou => cou.Course).ToListAsync();
            }

            if (idUser != null)
            {
                var student = await _context.Student.FirstOrDefaultAsync(s => s.IdUser == idUser);
                Student = student;

                var userSesion = await _context.Users.FirstOrDefaultAsync(u => u.IdUser == idUser);
                UserSesion = userSesion;
            }
        }

        public async Task<IActionResult> OnPostAsync(int? IdUser)
        {
            if (!ModelState.IsValid || _context.Inscription == null || Inscription == null)
            {
                return Page();
            }

            _context.Inscription.Add(Inscription);
            await _context.SaveChangesAsync();

            return RedirectToPage("/Aula/AulaStudent", new { id = IdUser });
        }
    }
}
