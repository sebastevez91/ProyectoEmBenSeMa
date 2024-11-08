﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolMusic.Entidades
{
    public class Student
    {
        [Key]
        public int IdStudent {  get; set; }
<<<<<<< HEAD
        [Required(ErrorMessage = "El nombre es obligatorio")]
        [StringLength(20)]
        public string NameStudent { get; set; }
        [Required(ErrorMessage = "El apellido es obligatorio")]
        [StringLength(20)]
        public string Surname { get; set; }
        [Required(ErrorMessage = "El email es obligatorio")]
        [EmailAddress(ErrorMessage = "Formato no válido")]
        public string Mail { get; set; }
        [Required(ErrorMessage = "El DNI es obligatorio")]
        [Range(10000000, 99999999, ErrorMessage = "El DNI debe tener 8 dígitos.")]
        public int Dni { get; set; }
        [Required(ErrorMessage = "La edad es obligatoria")]
=======
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
>>>>>>> secondMain
        [Range(18, 99, ErrorMessage = "La edad debe estar entre 18 y 99 años.")]
        public int Age { get; set; }
        public int IdUser { get; set; }
        [Required(ErrorMessage = "El género es obligatorio.")]
<<<<<<< HEAD
        [RegularExpression("Masculino|Femenino|Otro", ErrorMessage = "Elige un género.")]
=======
        [RegularExpression("Masculino|Femenino|Otro", ErrorMessage = "Seleccione una opción válida.")]
>>>>>>> secondMain
        public string Genero {  get; set; }

        // Relación con Inscription (uno a muchos)
        public ICollection<Inscription> Inscriptions { get; set; }

        public Student(int idStudent, string name, string surname, string mail, int dni, int age, int idUser, string genero)
        {
            IdStudent = idStudent;
            NameStudent = name;
            Surname = surname;
            Mail = mail;
            Dni = dni;
            Age = age;
            IdUser = idUser;
            Genero = genero;
        }
        public Student() { }
    }
}
