using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolMusic.Entidades
{
    internal class NotifiTeacher
    {
        [Key]
        public int IdNotifiTeacher {  get; set; }
        public int IdTeacher { get; set; }
        public int IdStudent {  get; set; }
        [StringLength(20)]
        public string Tipo {  get; set; }
        public string Subject {  get; set; }
        public string Body {  get; set; }
        public DateTime DateNotification { get; set; }
    }
}
