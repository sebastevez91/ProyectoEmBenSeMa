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
        public int IdComent { get; set; }

        [Required(ErrorMessage = "El contenido del comentario es obligatorio.")]
        [StringLength(500, ErrorMessage = "El comentario no puede tener más de 500 caracteres.")]
        public string Content { get; set; }

        [Required]
        public int IdTopic { get; set; }

        public DateTime DateComent { get; set; } = DateTime.Now;

        [Required]
        public string Author { get; set; }

        // Relación con Topic
        public Topic? Topic { get; set; }
    }
}
