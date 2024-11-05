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
<<<<<<< HEAD
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d).+$", ErrorMessage = "La contraseña debe contener al menos una letra minúscula, una letra mayúscula y un número.")]
=======
>>>>>>> secondMain
        public string UserPassword { get; set; }
        public byte? ChangePassword { get; set; } = default!;

        public Users(int idUser, string username, string password)
        {
            IdUser = idUser;
            Username = username;
            UserPassword = password;
        }

        public Users()
        {
        }
    }
}
