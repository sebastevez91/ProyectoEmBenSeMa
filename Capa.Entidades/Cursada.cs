using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolMusic.Entidades
{
    public class Cursada
    {
        // Propiedades
        [Key]
        public int IdCursada { get; set; }
        public int IdCourse { get; set; }
        public DateTime Initiation { get; set; }
        public DateTime Finish { get; set; }
        public int IdTeacher { get; set; }
        [DataType(DataType.Time)]
        public DateTime StarTime {  get; set; }
        [DataType(DataType.Time)]
        public DateTime EndTime {  get; set; }
        public int Vacantes {  get; set; }
        public string Days {  get; set; }
        public string Description {  get; set; }
        public float PayFee {  get; set; }

        // FK
        public Course Course { get; set; }
        public Teacher Teacher { get; set; }
        public Cursada()
        {
        }
    }
}
