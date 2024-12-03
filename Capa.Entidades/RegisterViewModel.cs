using System.ComponentModel.DataAnnotations;

namespace SchoolMusic.Web.Pages.Logins
{
    public class RegisterViewModel
    {
        // Datos de Usuario
        [Required]
        public string Username { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Compare(nameof(Password), ErrorMessage = "Las contraseñas no coinciden")]
        public string ConfirmPassword { get; set; }

        [Required]
        public string Rol { get; set; } // "Profesor" o "Alumno"


        // Datos Personales
        [Required]
        public string Name { get; set; }

        [Required]
        public string Surname { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public int Dni { get; set; }

        [Required]
        [Range(1, 120, ErrorMessage = "Edad no válida")]
        public int Age { get; set; }

        [Required]
        public string Genero { get; set; }
    }

}
