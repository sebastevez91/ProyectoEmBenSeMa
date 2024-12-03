using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SchoolMusic.Entidades;

namespace SchoolMusic.Web.Pages.Students
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
        public Student Student { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync()
        {
            var userId = User.FindFirst("UserId")?.Value;

            if (string.IsNullOrEmpty(userId))
            {
                return RedirectToPage("/Logins/LoginUser");
            }

            var student = await _context.Student.FirstOrDefaultAsync(m => m.IdUser == int.Parse(userId));
            if (student == null)
            {
                return NotFound();
            }
            Student = student;
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
                Student.FotoStudent = imageUrl;
            }

            _context.Attach(Student).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return RedirectToPage("/Aula/AulaStudent");
        }
    }
}
