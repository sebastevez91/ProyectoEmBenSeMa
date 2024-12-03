using System.ComponentModel.DataAnnotations;

namespace SchoolMusic.Entidades
{
    public class Assitance
    {
        [Key]
        public int IdAssitance { get; set; }
        public int IdInscription { get; set; }
        [Required(ErrorMessage = "Estado es requerido.")]
        [RegularExpression("Presente|Ausente", ErrorMessage = "Seleccione una opción válida.")]
        public string Status { get; set; }
        public DateTime DateAssitance { get; set; }

        //// FK
        //public Cursada? Cursada { get; set; }
    }
}
