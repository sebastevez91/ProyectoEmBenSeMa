using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SchoolMusic.Entidades;
using SchoolMusic.Web.Data;

namespace SchoolMusic.Web.Pages.Cursadas
{
    public class DeleteModel : PageModel
    {
        private readonly SchoolMusic.Web.Data.SchoolMusicWebContext _context;

        public DeleteModel(SchoolMusic.Web.Data.SchoolMusicWebContext context)
        {
            _context = context;
        }

        [BindProperty]
      public Cursada Cursada { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Cursada == null)
            {
                return NotFound();
            }

            var cursada = await _context.Cursada.FirstOrDefaultAsync(m => m.IdCursada == id);

            if (cursada == null)
            {
                return NotFound();
            }
            else 
            {
                Cursada = cursada;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.Cursada == null)
            {
                return NotFound();
            }
            var cursada = await _context.Cursada.FindAsync(id);

            if (cursada != null)
            {
                Cursada = cursada;
                _context.Cursada.Remove(Cursada);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Details", new { id = Cursada?.IdTeacher });
        }
    }
}
