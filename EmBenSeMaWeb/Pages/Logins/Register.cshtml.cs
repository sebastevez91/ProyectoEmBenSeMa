using Capa.Entidades;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SchoolMusic.Entidades;

namespace SchoolMusic.Web.Pages.Logins
{
    public class RegisterModel : PageModel
    {
        private readonly SchoolMusic.Web.Data.SchoolMusicWebContext _context;
        private readonly SchoolMusic.Web.Service.MailService _mailService;
        public RegisterModel(SchoolMusic.Web.Data.SchoolMusicWebContext context, Service.MailService mailService)
        {
            _context = context;
            _mailService = mailService;
        }
        public void OnGet()
        {
        }

        [BindProperty]
        public RegisterViewModel RegisterViewModel { get; set; }
        public MailData MailData { get; set; }


        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            try
            {
                // Crear usuario
                var user = new Users
                {
                    Username = RegisterViewModel.Username,
                    UserPassword = RegisterViewModel.Password,
                    Rol = RegisterViewModel.Rol
                };
                _context.Users.Add(user);
                await _context.SaveChangesAsync();

                // Crear datos específicos según el rol
                if (RegisterViewModel.Rol == "Profesor")
                {
                    var teacher = new Teacher
                    {
                        NameTeacher = RegisterViewModel.Name,
                        Surname = RegisterViewModel.Surname,
                        Mail = RegisterViewModel.Email,
                        Dni = RegisterViewModel.Dni,
                        Age = RegisterViewModel.Age,
                        IdUser = user.IdUser,
                        Genero = RegisterViewModel.Genero,
                    };
                    _context.Teacher.Add(teacher);
                }
                else if (RegisterViewModel.Rol == "Alumno")
                {
                    var student = new Student
                    {
                        NameStudent = RegisterViewModel.Name,
                        Surname = RegisterViewModel.Surname,
                        Mail = RegisterViewModel.Email,
                        Dni = RegisterViewModel.Dni,
                        Age = RegisterViewModel.Age,
                        IdUser = user.IdUser,
                        Genero = RegisterViewModel.Genero
                    };
                    _context.Student.Add(student);
                }

                await _context.SaveChangesAsync();

                // Construimos el cuerpo del correo con la información proporcionada por el usuario.
                MailData.subject = $"Asunto: Nuevo usuario de School EmBenSeMa";
                MailData.body = $"Te damos la bienvenida a la mejor plataforma educativa de musica";

                _mailService.sendMail(MailData);
                TempData["Message"] = "¡Te registraste exitosamente!";
            }
            catch (Exception ex)
            {
                ModelState.AddModelError(string.Empty, "Error al registrar el usuario: " + ex.Message);
                TempData["ErrorMessage"] = "No se pudo registrar tu usuario. Intenta nuevamente";
                return RedirectToPage("/Register");
            }

            return RedirectToPage("/Logins/RegisterExitoso");
        }
    }
}
