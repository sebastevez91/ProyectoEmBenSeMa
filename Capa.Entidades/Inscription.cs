using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolMusic.Entidades
{
    public class Inscription
    {
        public int idInscription {  get; set; }
        public int idStudent { get; set; }
        public int idCursada { get; set; }
        public DateTime dateInscription { get; set; }

        public Inscription(int idInscription, int idStudent, int idCursada, DateTime dateInscription)
        {
            this.idInscription = idInscription;
            this.idStudent = idStudent;
            this.idCursada = idCursada;
            this.dateInscription = dateInscription;
        }

        public Inscription() { }
    }
}
