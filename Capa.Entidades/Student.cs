using System;
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
        public string NameStudent { get; set; }
        public string Surname { get; set; }
        public string Mail { get; set; }
        public int Dni { get; set; }
        public int Age { get; set; }
        public int IdUser { get; set; }
        public string Genero {  get; set; }

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
