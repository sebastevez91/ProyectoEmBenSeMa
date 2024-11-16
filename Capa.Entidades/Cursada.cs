using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SchoolMusic.Entidades
{
    public class Cursada
    {
        // Propiedades
        [Key]
        public int IdCursada { get; set; }
        public int IdCourse { get; set; }
        [Required(ErrorMessage = "La fecha de inicio es obligatoria")]
        public DateTime Initiation { get; set; }
        [Required(ErrorMessage = "la fecha final es obligatoria")]
        public DateTime Finish { get; set; }
        public int IdTeacher { get; set; }
        [Required(ErrorMessage = "Se tiene que poner la de inicio de cursada")]
        [DataType(DataType.Time)]
        public DateTime StarTime {  get; set; }
        [Required(ErrorMessage = "Se tiene que poner la en que finaliza la cursada")]
        [DataType(DataType.Time)]
        public DateTime EndTime {  get; set; }
        [Required(ErrorMessage = "Ingrese la cantidad de vacantes que tiene la cursada")]
        [Range(1, 50, ErrorMessage = "La cantidad de vacantes no debe superar los 50.")]
        public int Vacantes {  get; set; }
        [Required(ErrorMessage = "El día de cursada es obligatorio")]
        [RegularExpression(@"^(?i)((lunes|martes|miercoles|jueves|viernes|sabado|domingo)([\s,]+)?)+$", ErrorMessage = "Debe ingresar días de la semana válidos, separados por comas o espacios.")]
        public string Days { get; set; }

        [Required(ErrorMessage = "Se tiene que ingresar el contenido de la cursada")]
        public string Description {  get; set; }
        [Required(ErrorMessage = "Ingrese el valor de la cuota")]
        public float PayFee {  get; set; }

        // FK
        public Course? Course { get; set; }
        public Teacher? Teacher { get; set; }
        
        // Relación con Inscription (uno a muchos)
        public ICollection<Inscription>? Inscriptions { get; set; }
        public Cursada()
        {
        }
    }
}
