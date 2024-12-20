﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolMusic.Entidades
{
    public class Teacher
    {
        [Key]
<<<<<<< HEAD
        public int IdTeacher {  get; set; }
        [Required(ErrorMessage = "El nombre es obligatorio")]
        [StringLength(20)]
        public string NameTeacher { get; set; }
        [Required(ErrorMessage = "El apellido es obligatorio")]
        [StringLength(20)]
        public string Surname { get; set; }
        [Required(ErrorMessage = "El email es obligatorio")]
        [EmailAddress(ErrorMessage = "Formato de correo inválido")]
        public string Mail { get; set; }
        [Required(ErrorMessage = "El DNI es obligatorio")]
        [Range(10000000, 99999999, ErrorMessage = "El DNI debe tener 8 dígitos.")]
        public int Dni { get; set; }
        [Required(ErrorMessage = "La edad es obligatoria")]
=======
        public int IdTeacher { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio.")]
        [StringLength(30)]
        public string NameTeacher { get; set; }

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
>>>>>>> secondMain
        [Range(18, 99, ErrorMessage = "La edad debe estar entre 18 y 99 años.")]
        public int Age { get; set; }

        public int IdUser { get; set; }
<<<<<<< HEAD
        [Required(ErrorMessage = "El género es obligatorio.")]
        [RegularExpression("Masculino|Femenino|Otro", ErrorMessage = "Elige un género.")]
        public string Genero {  get; set; }
=======

        [Required(ErrorMessage = "El género es obligatorio.")]
        [RegularExpression("Masculino|Femenino|Otro", ErrorMessage = "Seleccione una opción válida.")]
        public string Genero { get; set; }

>>>>>>> secondMain
        public string? FotoTeacher { get; set; }
        public string? Description { get; set; }

        // FK
        public IList<Cursada>? Cursada { get; set; } 
        public Users? Users { get; set; }
        public Teacher()
        {
        }
    }
}
