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
    public class DetailsModel : PageModel
    {
        private readonly SchoolMusic.Web.Data.SchoolMusicWebContext _context;

        public DetailsModel(SchoolMusic.Web.Data.SchoolMusicWebContext context)
        {
            _context = context;
        }

        public IList<Cursada> Cursadas { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Cursada == null)
            {
                return NotFound();
            }

            Cursadas = await _context.Cursada
                .Include(t => t.Teacher )
                .Include(c => c.Course)
                .Where(c => c.IdTeacher == id)
                .ToListAsync();

            if (Cursadas == null || Cursadas.Count == 0)
            {
                return NotFound(); // Si no hay Cursadas asociadas, devolver NotFound
            }

            return Page();
        }
    }
}
