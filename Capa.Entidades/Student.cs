using System.ComponentModel.DataAnnotations;

namespace SchoolMusic.Entidades
{
    public class Student
    {
        [Key]
        public int IdStudent { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio.")]
        [StringLength(30)]
        public string NameStudent { get; set; }

        [Required(ErrorMessage = "El apellido es obligatorio.")]
        [StringLength(30)]
        public string Surname { get; set; }

        [Required(ErrorMessage = "El correo es obligatorio.")]
        [EmailAddress(ErrorMessage = "Formato de correo inválido.")]
        public string Mail { get; set; }

        [Required(ErrorMessage = "El DNI es obligatorio.")]
        [Range(10000000, 99999999, ErrorMessage = "El DNI debe tener 8 dígitos.")]
        public int Dni { get; set; }

        [Required(ErrorMessage = "La edad es obligatoria.")]
        [Range(18, 99, ErrorMessage = "La edad debe estar entre 18 y 99 años.")]
        public int Age { get; set; }

        public int IdUser { get; set; }

        [Required(ErrorMessage = "El género es obligatorio.")]
        [RegularExpression("Masculino|Femenino|Otro", ErrorMessage = "Seleccione una opción válida.")]
        public string Genero { get; set; }
        public string? FotoStudent { get; set; }

        // Relación con Inscription (uno a muchos)
        public IList<Inscription>? Inscriptions { get; set; }

        public Student() { }
    }
}
