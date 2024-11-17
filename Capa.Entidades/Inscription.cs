using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolMusic.Entidades
{
    public class Inscription
    {
        [Key]
        public int idInscription {  get; set; }
        // Clave foránea para Student
        public int idStudent { get; set; }
        public Student? Student { get; set; }
        // Clave foránea para Cursada
        public int idCursada { get; set; }
        public Cursada? Cursada { get; set; }
        public DateTime dateInscription { get; set; }
        public string? Status {  get; set; }

        public Inscription() { }
    }
}
