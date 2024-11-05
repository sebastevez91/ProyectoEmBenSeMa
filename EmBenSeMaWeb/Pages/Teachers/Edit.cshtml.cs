using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SchoolMusic.Entidades;

namespace SchoolMusic.Web.Pages.Teachers
{
    public class EditModel : PageModel
    {
        private readonly SchoolMusic.Web.Data.SchoolMusicWebContext _context;
        private readonly ImageService _imageService;

        public EditModel(SchoolMusic.Web.Data.SchoolMusicWebContext context, ImageService imageService)
        {
            _context = context;
            _imageService = imageService;
        }

        [BindProperty]
        public Teacher Teacher { get; set; } = default!;
        public string newPerfile { get; set; }
        public string AlertMessage { get; set; }
        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Teacher == null)
            {
                return NotFound();
            }

            var teacher = await _context.Teacher.FirstOrDefaultAsync(m => m.IdTeacher == id);
            if (teacher == null)
            {
                return NotFound();
            }
            Teacher = teacher;
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync(IFormFile ProfileImage)
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            // Obtener el registro actual de Teacher desde la base de datos
            var teacherInDb = await _context.Teacher.FindAsync(Teacher.IdTeacher);

            // Si hay una nueva imagen seleccionada, súbela a Cloudinary y actualiza la URL
            if (ProfileImage != null)
            {
                var imageUrl = await _imageService.UploadImageAsync(ProfileImage);
                Teacher.FotoTeacher = imageUrl;
            }
            else
            {
                // Si no hay nueva imagen, mantener la URL existente
                Teacher.FotoTeacher = teacherInDb.FotoTeacher;
            }

            // Actualizar otros datos de Teacher
            _context.Entry(teacherInDb).CurrentValues.SetValues(Teacher);
            _context.Entry(teacherInDb).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TeacherExists(Teacher.IdTeacher))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            AlertMessage = "Perfil actualizado";
            return RedirectToPage("/Aula/AulaTeacher", new { id = Teacher?.IdUser });
        }


        private bool TeacherExists(int id)
        {
            return (_context.Teacher?.Any(e => e.IdTeacher == id)).GetValueOrDefault();
        }
    }
}
