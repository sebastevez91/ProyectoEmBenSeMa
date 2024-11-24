using System.ComponentModel.DataAnnotations;

namespace SchoolMusic.Entidades
{
    public class Users
    {
        [Key]
        public int IdUser { get; set; }
        [Required(ErrorMessage = "El nombre de usuario es obligatorio")]
        [StringLength(20, ErrorMessage = "El nombre de usuario no puede tener más de 20 caracteres.")]
        public string Username { get; set; }
        [Required(ErrorMessage = "La contraseña es obligatoria")]
        [StringLength(100, MinimumLength = 8, ErrorMessage = "La contraseña debe tener al menos 8 caracteres.")]
        public string UserPassword { get; set; }
        public byte? ChangePassword { get; set; } = default!;
        public string Rol { get; set; }

        // FK
        public Teacher? Teacher { get; set; }
        public Student? Student { get; set; }

        public Users()
        {
        }
    }
}
