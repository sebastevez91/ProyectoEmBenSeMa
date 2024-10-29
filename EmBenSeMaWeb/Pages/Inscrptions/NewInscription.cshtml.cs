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

namespace SchoolMusic.Web.Pages.Inscrptions
{
    public class NewInscriptionModel : PageModel
    {
        private readonly SchoolMusic.Web.Data.SchoolMusicWebContext _context;

        public NewInscriptionModel(SchoolMusic.Web.Data.SchoolMusicWebContext context)
        {
            _context = context;
        }

        public Cursada Cursada { get; set; } = default!;
        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Cursada == null)
            {
                return NotFound();
            }

            var cursada = await _context.Cursada
                .Include(c => c.Course)
                .FirstOrDefaultAsync(m => m.IdCursada == id);
            if (cursada == null)
            {
                return NotFound();
            }
            Cursada = cursada;
            return Page();
        }

        [BindProperty]
        public Inscription Inscription { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.Inscription == null || Inscription == null)
            {
                return Page();
            }

            _context.Inscription.Add(Inscription);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
