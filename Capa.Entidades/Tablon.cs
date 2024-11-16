using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolMusic.Entidades
{
    public class Tablon
    {
        [Key]
        public int idTablon { get; set; }
        public int idCursada { get; set; }
        public string? Description { get; set; }
    }
}
