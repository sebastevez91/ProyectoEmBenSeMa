using Capa.Base.De.Datos;
using SchoolMusic.BD;
using SchoolMusic.Entidades;
using System.Data;

namespace SchoolMusic.Serv
{
    public class PayService
    {
        Dictionary<string, string> prm = new Dictionary<string, string>();
        Payment Payment = new Payment();
        List<Inscription> inscriptions = new List<Inscription>();
        CnxSelect select = new CnxSelect();
        CnxAccion accion = new CnxAccion();
        public Payment GetPayment(int idInscription)
        {
            // Agrego parametros
            prm.Clear();
            prm.Add("@idInscription", idInscription.ToString());

            // Query
            string sqlQueryPay = "SELECT * FROM Payment WHERE IdInscription = @idInscription";
            var dataPayment = select.SelectData(sqlQueryPay, prm);

            if (dataPayment != null && dataPayment.Rows.Count > 0)
            {
                foreach (DataRow p in dataPayment.Rows)
                {
                    Payment = new()
                    {
                        IdPayment = int.Parse(p["IdPayment"].ToString()),
                        IdInscription = int.Parse(p["IdInscription"].ToString()),
                        PaymentStatus = p["PaymentStatus"].ToString(),
                        TypePay = p["TypePay"].ToString(),
                        Amount = float.Parse(p["Amount"].ToString()),
                        DatePayment = Convert.ToDateTime(p["DatePayment"].ToString())
                    };
                }
            }
            return Payment;
        }
        public bool PaymentCuota(int idPayment,string typePay)
        {
            // En este método actualizamos el campo PaymentStatus de la tabla Payment
            int result = 0;
            // Agrego parametros
            prm.Clear();
            prm.Add("@idPayment", idPayment.ToString());
            prm.Add("@typePay", typePay.ToString());

            // Query
            string sqlQueryPay = "UPDATE Payment SET PaymentStatus = 'Pagada', TypePay = @typePay WHERE IdPayment = @idPayment";
            result = accion.AccionEjecutar(sqlQueryPay, prm);

            return result > 0 ? true : false;
        }
        public List<Inscription> GetInscriptions(int idStudent)
        {
            inscriptions.Clear();
            // Agrego parametros
            prm.Clear();
            prm.Add("@idStudent", idStudent.ToString());

            // Query
            string sqlQueryInscription = "SELECT * FROM Inscription WHERE IdStudent = @idStudent";
            var dataIncription = select.SelectData(sqlQueryInscription, prm).Rows[0];

            inscriptions.Add(new()
            {
                idInscription = int.Parse(dataIncription["IdInscription"].ToString()),
                idCursada = int.Parse(dataIncription["IdCursada"].ToString()),
                idStudent = int.Parse(dataIncription["IdStudent"].ToString()),
                dateInscription = Convert.ToDateTime(dataIncription["DateInscription"].ToString())
            });
            return inscriptions;
        }
    }
}
