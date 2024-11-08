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
        public DateTime DatePayment { get; set;}
        public string TypePay { get; set; }
        public float Amount { get; set; }

        public Payment()
        {

        }
    }
}
