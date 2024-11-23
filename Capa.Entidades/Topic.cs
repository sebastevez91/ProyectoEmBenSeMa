using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolMusic.Entidades
{
    public class Topic
    {
        [Key]
        public int IdTopic {  get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime DateTopic { get; set; }
        public int IdCursada { get; set; }

        // FK
        public ICollection<Coment>? Coments { get; set; }
    }
}
