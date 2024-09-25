using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolMusic.Entidades
{
    public class Payment
    {
        public int IdPayment { get; set; }
        public int IdInscription { get; set; }
        public string PaymentStatus { get; set; }
        public string Month { get; set;}
        public int Year { get; set;}
        public string Metodo { get; set; }
        public string Fecha { get; set; }

        public Payment(int idPayment, int idInscription, string paymentStatus, string metodo, string month, int year)
        {
            IdPayment = idPayment;
            IdInscription = idInscription;
            PaymentStatus = paymentStatus;
            Month = month;
            Year = year;
            Metodo = metodo;
        }

        public Payment()
        {

        }
    }
}
