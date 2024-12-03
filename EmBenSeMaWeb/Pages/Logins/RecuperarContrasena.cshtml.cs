using Capa.Entidades;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SchoolMusic.Entidades;
using System.ComponentModel.DataAnnotations;

namespace SchoolMusic.Web.Pages.Logins
{
    public class RecuperarContrasenaModel : PageModel
    {
        private readonly SchoolMusic.Web.Data.SchoolMusicWebContext _context;
        private readonly SchoolMusic.Web.Service.MailService _mailService;

        public RecuperarContrasenaModel(SchoolMusic.Web.Data.SchoolMusicWebContext context, Service.MailService mailService)
        {
            _context = context;
            _mailService = mailService;
        }

        public void OnGet()
        {
        }
        [BindProperty]
        public MailData MailData { get; set; } = default!;
        [BindProperty]
        [Required(ErrorMessage = "El rol es obligatorio.")]
        public string Rol {  get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (string.IsNullOrWhiteSpace(MailData.mailTo) || string.IsNullOrWhiteSpace(Rol))
            {
                ModelState.AddModelError(string.Empty, "El correo y el rol son obligatorios.");
                return Page();
            }

            try
            {
                await ChangesPasswordAsync(MailData.mailTo, Rol);
                TempData["Message"] = "La nueva contraseña se ha enviado a tu correo electrónico.";
            }
            catch (Exception ex)
            {
                ModelState.AddModelError(string.Empty, $"Hubo un error: {ex.Message}");
            }

            return Page();
        }


        private async Task ChangesPasswordAsync(string email, string rol)
        {
            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(rol))
            {
                throw new ArgumentException("Correo electrónico o rol no válido.");
            }

            // Generar una contraseña segura
            string newPassword = Guid.NewGuid().ToString("N").Substring(0, 8);

            if (rol == "Profesor")
            {
                var teacher = await _context.Teacher
                    .Include(t => t.Users)
                    .FirstOrDefaultAsync(t => t.Mail == email);

                if (teacher == null)
                {
                    throw new InvalidOperationException("No se encontró un profesor con ese correo.");
                }

                teacher.Users.UserPassword = newPassword;
                teacher.Users.ChangePassword = 1;
            }
            else if (rol == "Alumno")
            {
                var student = await _context.Student
                    .Include(s => s.Users)
                    .FirstOrDefaultAsync(s => s.Mail == email);

                if (student == null)
                {
                    throw new InvalidOperationException("No se encontró un alumno con ese correo.");
                }

                student.Users.UserPassword = newPassword;
                student.Users.ChangePassword = 1;
            }
            else
            {
                throw new ArgumentException("Rol no válido.");
            }

            // Guardar los cambios en la base de datos
            await _context.SaveChangesAsync();

            // Enviar la nueva contraseña por correo
            var mailData = new MailData
            {
                mailTo = email,
                subject = "Recuperación de contraseña",
                body = $"Inicia sesión en el aula virtual con tu nueva contraseña es: {newPassword}"
            };
            _mailService.sendMail(mailData);
        }

    }
}
