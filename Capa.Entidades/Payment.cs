using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolMusic.Entidades
{
    public class Payment
    {
        [Key]
        public int IdPayment { get; set; }
        public int IdInscription { get; set; }
        public string PaymentStatus { get; set; }
        public string Month { get; set;}
        public int Year { get; set;}
        public string Metodo { get; set; }
        public string Fecha { get; set; }

        public Payment()
        {

        }
    }
}
