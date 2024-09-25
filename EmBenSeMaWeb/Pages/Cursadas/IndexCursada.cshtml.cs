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

        public async Task OnGetAsync()
        {
            if (_context.Cursada != null)
            {
                Cursada = await _context.Cursada.Include(cou => cou.Course).ToListAsync();
            }
        }
    }
}
