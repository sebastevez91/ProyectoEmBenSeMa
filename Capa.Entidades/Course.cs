using System.ComponentModel.DataAnnotations;

namespace SchoolMusic.Entidades
{
    public class Course
    {
        // Propiedades
        [Key]
        public int IdCourse { get; set; }
        public string Instrument { get; set; }
        public string? ImagenURL {  get; set; }
        public string? Description { get; set; }
        
        // FK
        public List<Cursada>? Cursadas { get; set; }

        // Constructores
        public Course(int idCourse, string instrument)
        {
            IdCourse = idCourse;
            Instrument = instrument;
        }
        public Course() { }

    }
}
