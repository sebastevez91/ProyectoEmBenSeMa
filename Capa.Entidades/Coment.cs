using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolMusic.Entidades
{
    public class Coment
    {
        public int idComent {  get; set; }
        public string comentDesc { get; set;}
        public int idTopic { get; set; }
        public DateTime dateComent { get; set; }
        public string nameUser { get; set; }
    }
}
