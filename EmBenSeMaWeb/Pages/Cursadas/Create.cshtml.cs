using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SchoolMusic.Entidades;

namespace SchoolMusic.Web.Pages.Cursadas
{
    public class CreateModel : PageModel
    {
        private readonly SchoolMusic.Web.Data.SchoolMusicWebContext _context;
        [BindProperty(SupportsGet = true)]
        public int idCourse { get; set; } = default!;
        [BindProperty(SupportsGet = true)]
        public int idTeacher { get; set; } = default!;

        public CreateModel(SchoolMusic.Web.Data.SchoolMusicWebContext context)
        {
            _context = context;
        }

        public  IActionResult OnGet(int idCourse, int idTeacher)
        {
            if(idCourse == 0 || idTeacher == 0)
            {
                return NotFound();
            }
            this.idCourse = idCourse;
            this.idTeacher = idTeacher;
            return Page();
        }

        [BindProperty]
        public Cursada? Cursada { get; set; } = new Cursada();


        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            Cursada.IdCourse = idCourse;
            Cursada.IdTeacher = idTeacher;
            if (!ModelState.IsValid || _context.Cursada == null || Cursada == null)
            {
                return Page();
            }

            _context.Cursada.Add(Cursada);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Details" ,new { id = Cursada?.IdTeacher });
        }
    }
}
