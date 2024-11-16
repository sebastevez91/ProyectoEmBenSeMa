using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SchoolMusic.Entidades;
using SchoolMusic.Web.Data;

namespace SchoolMusic.Web.Pages.Cursadas
{
    public class EditModel : PageModel
    {
        private readonly SchoolMusic.Web.Data.SchoolMusicWebContext _context;

        public EditModel(SchoolMusic.Web.Data.SchoolMusicWebContext context)
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

            var cursada =  await _context.Cursada
                .Include(c => c.Course)
                .FirstOrDefaultAsync(m => m.IdCursada == id);
            if (cursada == null)
            {
                return NotFound();
            }
            Cursada = cursada;
            return Page();
        }
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Cursada).State = EntityState.Modified;
                await _context.SaveChangesAsync();

            return RedirectToPage("./Details");
        }
    }
}
