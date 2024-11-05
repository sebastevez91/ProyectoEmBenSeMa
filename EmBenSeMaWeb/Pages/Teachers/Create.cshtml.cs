using CloudinaryDotNet.Actions;
using CloudinaryDotNet;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SchoolMusic.Entidades;
using SchoolMusic.Serv;

namespace SchoolMusic.Web.Pages.Teachers
{
    public class CreateModel : PageModel
    {
        private readonly SchoolMusic.Web.Data.SchoolMusicWebContext _context;
        private readonly ImageService _imageService; // Inyectar ImageService

        public CreateModel(SchoolMusic.Web.Data.SchoolMusicWebContext context, ImageService imageService)
        {
            _context = context;
            _imageService = imageService;
        }

        public IActionResult OnGet()
        {
            return Page();
        }


        [BindProperty]
        public Teacher Teacher { get; set; } = default!;

        [BindProperty]
        public Users Users { get; set; } = default!;

        [BindProperty]
        public string rePassword { get; set; } = default!;

        public int idUser { get; set; }
        public string confirmacionRegistro = ""; 

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync(IFormFile ProfileImage)
        {
            if (!ModelState.IsValid || _context.Teacher == null || Teacher == null)
            {
                return Page();
            }

            // Verificar si las contraseñas coinciden
            if (Users.UserPassword != rePassword)
            {
                ModelState.AddModelError(string.Empty, "Las contraseñas ingresadas no son idénticas");
                return Page();
            }

            // Si hay una imagen seleccionada, súbela a Cloudinary
            if (ProfileImage != null)
            {
                var imageUrl = await _imageService.UploadImageAsync(ProfileImage);
                Teacher.FotoTeacher = imageUrl; // Guardar la URL en el modelo Teacher
            }

            // Agregar el usuario y guardar los cambios
            _context.Users.Add(Users);
            await _context.SaveChangesAsync();

            // Obtener el Id del usuario recién creado
            Teacher.IdUser = Users.IdUser;
            _context.Teacher.Add(Teacher);
            await _context.SaveChangesAsync();

            confirmacionRegistro = "Registro exitoso";

            return RedirectToPage("./Index");
        }
    }
}
