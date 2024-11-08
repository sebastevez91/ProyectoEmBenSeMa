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

            try
            {
                // Query
                string sqlQueryPay = "SELECT * FROM Payment WHERE IdInscription = @idInscription";
                var dataPayment = select.SelectData(sqlQueryPay, prm);

                if (dataPayment != null && dataPayment.Rows.Count > 0)
                {
                    var table = dataPayment.Rows[0];
                    Payment = new()
                    {
                        IdPayment = int.Parse(table["IdPayment"].ToString()),
                        IdInscription = int.Parse(table["IdInscription"].ToString()),
                        PaymentStatus = table["PaymentStatus"].ToString(),
                        TypePay = table["TypePay"].ToString(),
                        Amount = float.Parse(table["Amount"].ToString()),
                        DatePayment = Convert.ToDateTime(table["DatePayment"].ToString())
                    };

                }
            }
            catch (Exception ex)
            {

                Console.WriteLine("Error: " + ex.Message);
                Payment = null;
            }
            return Payment;
        }
        public bool PaymentCuota(int idPayment, string typePay)
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

            try
            {
                // Query
                string sqlQueryInscription = "SELECT * FROM Inscription WHERE IdStudent = @idStudent";
                var dataInscription = select.SelectData(sqlQueryInscription, prm);
                if (dataInscription != null && dataInscription.Rows.Count > 0)
                {
                    foreach (DataRow ins in dataInscription.Rows)
                    {
                        inscriptions.Add(new()
                        {
                            idInscription = int.Parse(ins["IdInscription"].ToString()),
                            idCursada = int.Parse(ins["IdCursada"].ToString()),
                            idStudent = int.Parse(ins["IdStudent"].ToString()),
                            dateInscription = Convert.ToDateTime(ins["DateInscription"].ToString())
                        });
                    }
                }

            }
            catch (Exception ex)
            {

                Console.WriteLine("Error: " + ex.Message);
            }
            return inscriptions;
        }
    }
}
