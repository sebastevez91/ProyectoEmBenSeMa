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
        public async Task<IActionResult> OnGetAsync()
        {
            var userId = User.FindFirst("UserId")?.Value;

            if (string.IsNullOrEmpty(userId))
            {
                return RedirectToPage("/Logins/LoginUser");
            }

            var teacher = await _context.Teacher.FirstOrDefaultAsync(m => m.IdUser == int.Parse(userId));
            if (teacher == null)
            {
                return NotFound();
            }
            Teacher = teacher;
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(IFormFile? ProfileImage)
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            if (ProfileImage != null)
            {
                // Subir y actualizar solo la imagen
                var imageUrl = await _imageService.UploadImageAsync(ProfileImage);
                Teacher.FotoTeacher = imageUrl;
            }

            _context.Attach(Teacher).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return RedirectToPage("/Aula/AulaTeacher");
        }

    }
}
