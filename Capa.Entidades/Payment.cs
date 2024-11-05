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
        public string DateTime { get; set;}
        public string TypePay { get; set; }
        public string Amount { get; set; }

        public Payment()
        {

        }
    }
}
