using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SchoolMusic.Entidades;

namespace SchoolMusic.Web.Pages.Tablons
{
    public class indexModel : PageModel
    {
        private readonly SchoolMusic.Web.Data.SchoolMusicWebContext _context;

        public indexModel(SchoolMusic.Web.Data.SchoolMusicWebContext context)
        {
            _context = context;
        }

        public IList<Topic> Topics { get; set; } = default!;
        public Cursada Cursada { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            // Cursada
            var cursada = await _context.Cursada
                .Include(c => c.Teacher)
                .Include(c => c.Course)
                .FirstOrDefaultAsync(c => c.IdCursada == id);

            // Publicaciones
            var topics = await _context.Topic
                .Include(c => c.Coments)
                .Where(c => c.IdCursada == id)
                .ToListAsync();

            Cursada = cursada;
            Topics = topics;
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            //_context.Tablon.Add(Tablon);
            await _context.SaveChangesAsync();

            return Page();
        }
    }
}
