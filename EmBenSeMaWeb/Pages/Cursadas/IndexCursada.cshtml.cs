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

        public async Task OnGetAsync(int? id)
        {
            if (id != null &&  _context.Cursada != null)
            {
                Cursada = await _context.Cursada
                    .Where(c => c.IdCourse == id)
                    .Include(cou => cou.Course).ToListAsync();
            }
            else
            {
                Cursada = await _context.Cursada
                    .Include(c => c.Course).ToListAsync();
            }
        }
    }
}
