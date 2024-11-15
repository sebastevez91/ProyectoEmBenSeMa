using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SchoolMusic.Entidades;

namespace SchoolMusic.Web.Pages.Logins
{
    public class RegisterModel : PageModel
    {
        private readonly SchoolMusic.Web.Data.SchoolMusicWebContext _context;
        public RegisterModel(SchoolMusic.Web.Data.SchoolMusicWebContext context)
        {
            _context = context;
        }
        public void OnGet()
        {
        }

        [BindProperty]
        public RegisterViewModel RegisterViewModel { get; set; }


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

            }
            catch (Exception ex)
            {
                ModelState.AddModelError(string.Empty, "Error al registrar el usuario: " + ex.Message);
                return RedirectToPage("~/Index");
            }

            return RedirectToPage("~/Index");
        }
    }
}
