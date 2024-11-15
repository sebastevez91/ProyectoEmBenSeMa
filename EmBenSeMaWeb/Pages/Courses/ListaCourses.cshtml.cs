using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SchoolMusic.Entidades;

namespace SchoolMusic.Web.Pages.Courses
{
    public class ListaCourse : PageModel
    {
        private readonly SchoolMusic.Web.Data.SchoolMusicWebContext _context;
        public ListaCourse(SchoolMusic.Web.Data.SchoolMusicWebContext context)
        {
            _context = context;
        }

        public IList<Course> Course { get; set; } = default!;
        public Users UserSesion { get; set; }
        public async Task OnGetAsync(int? idUser)
        {
            if (idUser != null)
            {
                UserSesion = await _context.Users.FirstOrDefaultAsync(u => u.IdUser == idUser);
            }
            if (_context.Course != null)
            {
                Course = await _context.Course.ToListAsync();
            }
        }
    }
}
