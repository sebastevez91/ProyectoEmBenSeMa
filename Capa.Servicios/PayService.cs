using Capa.Base.De.Datos;
using SchoolMusic.BD;
using SchoolMusic.Entidades;
using System.Data;

namespace SchoolMusic.Serv
{
    public class PayService
    {
        // Creamos un diccionario para los parámetros que vamos a utilizar
        Dictionary<string, string> prm = new Dictionary<string, string>();
        // Creamos una lista para almacenar todos los objetos de tipo Payment.
        List<Payment> listPay = new List<Payment>();
        // Instaciamos la conexión con las clases CxnSelect y CxnAcción de la capa Datos
        CnxSelect select = new CnxSelect();
        CnxAccion accion = new CnxAccion();
        public List<Payment> GetPayment(int idInscription)
        {
            // Traemos todos los registros relacionados con el IdInscription.
            // Agrego parametros
            prm.Clear();
            prm.Add("@idInscription", idInscription.ToString());

            // Query
            string sqlQueryPay = "SELECT *, CONCAT(Month, ' / ',Year) AS Fecha FROM Payment WHERE IdInscription = @idInscription";
            var dataPayment = select.SelectData(sqlQueryPay, prm);

            if (dataPayment != null && dataPayment.Rows.Count > 0)
            {
                foreach (DataRow p in dataPayment.Rows)
                {
                    listPay.Add(new()
                    {
                        IdPayment = int.Parse(p["IdPayment"].ToString()),
                        IdInscription = int.Parse(p["IdInscription"].ToString()),
                        PaymentStatus = p["PaymentStatus"].ToString(),
                        //Month = p["Month"].ToString(),
                        //Year = int.Parse(p["Year"].ToString()),
                        //Metodo = p["TypePay"].ToString(),
                        //Fecha = p["Fecha"].ToString()
                    });
                }
            }
            return listPay;
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
        public Inscription GetInscription(int idStudent, int idCursada)
        {
            // En este método traemos el registro de la tabla Inscription según el Id del alumno y el Id de cursada.
            Inscription inscription = null;
            // Agrego parametros
            prm.Clear();
            prm.Add("@idStudent", idStudent.ToString());
            prm.Add("@idCursada", idCursada.ToString());

            // Query
            string sqlQueryInscription = "SELECT * FROM Inscription WHERE IdStudent = @idStudent AND IdCursada = @idCursada";
            var dataIncription = select.SelectData(sqlQueryInscription, prm).Rows[0];

            inscription = new()
            {
                idInscription = int.Parse(dataIncription["IdInscription"].ToString()),
                idCursada = int.Parse(dataIncription["IdCursada"].ToString()),
                idStudent = int.Parse(dataIncription["IdStudent"].ToString()),
                dateInscription = Convert.ToDateTime(dataIncription["DateInscription"].ToString())
            };
            return inscription;
        }
        public int GetIdInscription(int idStudent, int idCursada)
        {
            // En este método traemos el Id de un registro de la tabla Inscription según Id del alumno.
            int result = 0;
            // Agrego parametros
            prm.Clear();
            prm.Add("@idStudent", idStudent.ToString());
            prm.Add("@idCursada", idCursada.ToString());

            // Query
            string sqlQueryInscription = "SELECT IdInscription FROM Inscription WHERE IdStudent = @idStudent AND IdCursada = @idCursada";
            try
            {
                var dataInscription = select.SelectData(sqlQueryInscription, prm).Rows[0];

                result = int.Parse(dataInscription["IdInscription"].ToString());
            }
            catch (Exception e)
            {

                //MessageBox.Show("No hay inscripciones hechas");
            }

            return result;
        }
    }
}
