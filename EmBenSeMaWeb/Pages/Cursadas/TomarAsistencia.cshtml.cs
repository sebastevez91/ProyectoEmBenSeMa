using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SchoolMusic.Entidades;

namespace SchoolMusic.Web.Pages.Cursadas
{
    public class TomarAsistenciaModel : PageModel
    {
        private readonly SchoolMusic.Web.Data.SchoolMusicWebContext _context;

        public TomarAsistenciaModel(SchoolMusic.Web.Data.SchoolMusicWebContext context)
        {
            _context = context;
        }

        public Cursada Cursada { get; set; } = default!;
        [BindProperty]
        public List<Assitance> Assistance { get; set; } = new();

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Cursada = await _context.Cursada
                .Include(c => c.Inscriptions)
                .ThenInclude(i => i.Student)
                .FirstOrDefaultAsync(c => c.IdCursada == id);

            if (Cursada == null)
            {
                TempData["Message"] = "La cursada no existe.";
                return RedirectToPage("./Index");
            }

            if (Cursada.Inscriptions == null || !Cursada.Inscriptions.Any())
            {
                TempData["Message"] = "No hay estudiantes inscritos en esta cursada.";
                return Page();
            }

            Assistance = InitializeAssistance(Cursada.Inscriptions);
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                var errors = ModelState.Values.SelectMany(v => v.Errors).Select(e => e.ErrorMessage).ToList();
                foreach (var error in errors)
                {
                    Console.WriteLine(error); // O usar un logger
                }
                return Page();
            }

            _context.Assitance.AddRange(Assistance);
            await _context.SaveChangesAsync();

            TempData["SuccessMessage"] = "La asistencia fue guardada correctamente.";
            return Page();
            //return RedirectToPage("./TomarAsistencia", new { id = idCursada });
            //try
            //{ 

            //    _context.Assitance.AddRange(Assistance);
            //    await _context.SaveChangesAsync();

            //    TempData["SuccessMessage"] = "La asistencia fue guardada correctamente.";
            //    return RedirectToPage("./TomarAsistencia", new { id = idCursada});
            //}
            //catch (Exception ex)
            //{
            //    ModelState.AddModelError(string.Empty, "Ocurrió un error al guardar los datos: " + ex.Message);
            //    return Page();
            //}
        }

        private List<Assitance> InitializeAssistance(IEnumerable<Inscription> inscriptions)
        {
            return inscriptions.Select(i => new Assitance
            {
                IdInscription = i.idInscription,
                Status = "Ausente"
            }).ToList();
        }
    }

}
