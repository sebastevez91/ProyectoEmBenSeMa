using System;
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
        public int IdTeacher {  get; set; }
        public string NameTeacher { get; set; }
        public string Surname { get; set; }
        public string Mail { get; set; }
        public int Dni { get; set; }
        public int Age { get; set; }
        public int IdUser { get; set; }
        public string Genero {  get; set; }
        public string? FotoTeacher { get; set; }
        public string? Description {  get; set; }

        // FK
        public IList<Cursada>? Cursada { get; set; } 

        public Teacher(int idTeacher, string name, string surname, string mail, int dni, int age, int idUser, string genero)
        {
            IdTeacher = idTeacher;
            NameTeacher = name;
            Surname = surname;
            Mail = mail;
            Dni = dni;
            Age = age;
            IdUser = idUser;
            Genero = genero;
        }


        public Teacher()
        {
        }
    }


}
