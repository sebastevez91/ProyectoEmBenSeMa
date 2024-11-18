using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SchoolMusic.Entidades;
using SchoolMusic.Web.Data;

namespace SchoolMusic.Web.Pages.Students
{
    public class DetailsModel : PageModel
    {
        private readonly SchoolMusic.Web.Data.SchoolMusicWebContext _context;

        public DetailsModel(SchoolMusic.Web.Data.SchoolMusicWebContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Inscription Inscription { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Inscription == null)
            {
                return NotFound();
            }

            // Consulta la inscripción con la relación cargada
            var inscription = await _context.Inscription
                                            .Include(i => i.Student) // Carga la relación con Student
                                            .FirstOrDefaultAsync(m => m.idInscription == id);

            if (inscription == null)
            {
                return NotFound();
            }
            else 
            {
                Inscription = inscription;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Inscription).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return RedirectToPage("/Students/Index", new {id = Inscription.idCursada});
        }
    }
}
