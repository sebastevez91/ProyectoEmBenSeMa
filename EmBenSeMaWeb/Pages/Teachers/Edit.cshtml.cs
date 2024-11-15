using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SchoolMusic.Entidades;

namespace SchoolMusic.Web.Pages.Teachers
{
    public class EditModel : PageModel
    {
        private readonly SchoolMusic.Web.Data.SchoolMusicWebContext _context;
        private readonly ImageService _imageService; // Inyectar ImageService

        public EditModel(SchoolMusic.Web.Data.SchoolMusicWebContext context, ImageService imageService)
        {
            _context = context;
            _imageService = imageService;
        }

        [BindProperty]
        public Teacher Teacher { get; set; } = default!;


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

        public async Task<IActionResult> OnPostAsync(IFormFile ProfileImage, string action)
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            // Obtener el registro actual de Teacher desde la base de datos
            var teacherInDb = await _context.Teacher.FindAsync(Teacher.IdTeacher);
            if (teacherInDb == null)
            {
                return NotFound();
            }

            if (action == "updateData")
            {
                // Actualizar solo los datos personales
                teacherInDb.NameTeacher = Teacher.NameTeacher;
                teacherInDb.Surname = Teacher.Surname;
                teacherInDb.Mail = Teacher.Mail;
                teacherInDb.Dni = Teacher.Dni;
                teacherInDb.Age = Teacher.Age;
                teacherInDb.Genero = Teacher.Genero;

                _context.Entry(teacherInDb).State = EntityState.Modified;
                await _context.SaveChangesAsync();
            }
            else if (action == "updateImage" && ProfileImage != null)
            {
                // Subir y actualizar solo la imagen
                var imageUrl = await _imageService.UploadImageAsync(ProfileImage);
                teacherInDb.FotoTeacher = imageUrl;

                _context.Entry(teacherInDb).State = EntityState.Modified;
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("/Aula/AulaTeacher", new { id = Teacher?.IdUser });
        }





        private bool TeacherExists(int id)
        {
            return (_context.Teacher?.Any(e => e.IdTeacher == id)).GetValueOrDefault();
        }
    }
}
