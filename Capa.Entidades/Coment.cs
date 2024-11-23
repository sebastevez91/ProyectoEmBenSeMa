using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolMusic.Entidades
{
    public class Coment
    {
        [Key]
        public int IdComent {  get; set; }
        public string Content { get; set;}
        public int IdTopic { get; set; }
        public DateTime DateComent { get; set; }
        public string Author { get; set; }

        // Fk
        public Topic? Topic { get; set; }
    }
}
