using Capa.Base.De.Datos;
using SchoolMusic.BD;
using SchoolMusic.Entidades;
using System.Data;

namespace SchoolMusic.Serv
{
    public class CourseService
    {
        Dictionary<string, string> prm = new Dictionary<string, string>();
        private CnxSelect select = new CnxSelect();
        private CnxAccion accion = new CnxAccion();
        public List<Course> GetListCourse()
        {
            List<Course> courses = new List<Course>();

            // Query
            string sqlQueryCourse = "SELECT * FROM Course";
            var dataCourse = select.SelectData(sqlQueryCourse, null);

            if (dataCourse != null && dataCourse.Rows.Count > 0)
            {
                foreach (DataRow course in dataCourse.Rows)
                {
                    courses.Add(new()
                    {
                        IdCourse = int.Parse(course["IdCourse"].ToString()),
                        Instrument = course["Instrument"].ToString()
                    });
                }
            }
            return courses;
        }
        public string GetNameTeacher(int idTeacher)
        {
            // Enviamos a la capa Datos la query para traer el nombre completo del profesor

            // Creamos variable
            string nameCompleto = "";

            // Agregamos parámetros
            prm.Clear();
            prm.Add("@idTeacher", idTeacher.ToString());

            // Query 
            string sqlQueryTeacher = "SELECT CONCAT(NameTeacher, ' ', Surname) AS Completo FROM Teacher WHERE IdTeacher = @idTeacher";
            var dataTeacher = select.SelectData(sqlQueryTeacher, prm).Rows[0];

            nameCompleto = dataTeacher["Completo"].ToString();
            return nameCompleto;
        }
        public List<Cursada> GetListCursadas(int idCourse)
        {
            // Enviamos a la capa de datos la query para pedir todas las cursadas de un curso

            // Creamos una lista para almacenar todas las cursadas
            List<Cursada> listCursadas = new List<Cursada>();

            // Agregamos parámetros
            prm.Clear();
            prm.Add("@idCourse", idCourse.ToString());

            // Query
            string sqlQueryCursada = "SELECT * FROM Cursada WHERE IdCourse = @idCourse";
            var dataCursada = select.SelectData(sqlQueryCursada, prm);

            if (dataCursada != null && dataCursada.Rows.Count > 0)
            {
                foreach (DataRow t in dataCursada.Rows)
                {
                    listCursadas.Add(new Cursada()
                    {
                        IdCursada = int.Parse(t["IdCursada"].ToString()),
                        IdCourse = int.Parse(t["IdCourse"].ToString()),
                        Initiation = Convert.ToDateTime(t["Initiation"].ToString()),
                        Finish = Convert.ToDateTime(t["Finish"].ToString()),
                        IdTeacher = int.Parse(t["IdTeacher"].ToString()),
                        StarTime = Convert.ToDateTime(t["StarTime"].ToString()),
                        EndTime = Convert.ToDateTime(t["EndTime"].ToString()),
                        Vacantes = int.Parse(t["Vacantes"].ToString()),
                        Days = t["Days"].ToString(),
                        Description = t["Description"].ToString(),
                        PayFee = float.Parse(t["PayFee"].ToString())
                    });
                }
            }
            return listCursadas;
        }
        public int GetCantidad(int idCursada)
        {
            int result = 0;
            // Agrego parametros
            prm.Clear();
            prm.Add("@idCursada", idCursada.ToString());

            // Query
            string sqlQueryInscription = "SELECT IdInscription FROM Inscription WHERE IdCursada = @idCursada";
            try
            {
                var dataCantidad = select.SelectData(sqlQueryInscription, prm);
                result = dataCantidad.Rows.Count;
            }
            catch (Exception e)
            {

                //MessageBox.Show("Error: " + e.Message);
            }
            return result;
        }
        public int GetIdInscription(int idStudent, int idCursada)
        {
            int result = 0;
            // Agrego parametros
            prm.Clear();
            prm.Add("@idStudent", idStudent.ToString());
            prm.Add("@idCursada", idCursada.ToString());

            // Query
            string sqlQueryInscription = "SELECT * FROM Inscription WHERE IdStudent = @idStudent AND IdCursada = @idCursada";
            try
            {
                var dataInscription = select.SelectData(sqlQueryInscription, prm).Rows[0];

                result = int.Parse(dataInscription["IdInscription"].ToString());
            }
            catch (Exception e)
            {

                return result;
            }

            return result;
        }
        public bool AddInscription(int idStudent, int idCursada)
        {
            int result = 0;
            // Agrego parametro
            prm.Clear();
            prm.Add("@idStudent", idStudent.ToString());
            prm.Add("@idCursada", idCursada.ToString());

            // Query
            string sqlInsertInscription = "INSERT INTO Inscription (IdStudent, IdCursada, DateInscription) " +
                    "VALUES (@idStudent, @idCursada, GETDATE())";

            result = accion.AccionEjecutar(sqlInsertInscription, prm);

            return result > 0 ? true : false;
        }
        public bool AddPayment(int idInscription, Cursada cursada)
        {
            List<string> listMonth = new List<string>();
            List<int> listYear = new List<int>();
            listMonth = GetMonthPayment(cursada);
            listYear = GetYearPayment(cursada);

            int result = 0;
            int contadorYear = 0;
            // Limpio el diccionario
            prm.Clear();

            foreach (string month in listMonth)
            {
                // Agrego parametros
                prm.Add("@idInscription", idInscription.ToString());
                prm.Add("@month", month);
                prm.Add("@year", listYear[contadorYear].ToString());
                // Query
                string sqlQueryPay = "INSERT INTO Payment (IdInscription,PaymentStatus,Month,Year)" +
                    "VALUES (@idInscription,'Pendiente',@month,@year)";
                result = accion.AccionEjecutar(sqlQueryPay, prm);
                prm.Clear();
                contadorYear++;
            }
            return result > 0 ? true : false;
        }
        private List<string> GetMonthPayment(Cursada cursada)
        {
            List<string> month = new List<string>();

            DateTime fechaInicio = cursada.Initiation; // Fecha de inicio
            DateTime fechaFin = cursada.Finish; // Fecha de fin

            while (fechaInicio <= fechaFin)
            {
                month.Add(fechaInicio.ToString("MMMM")); // Agrega el nombre del mes a la lista
                fechaInicio = fechaInicio.AddMonths(1); // Incrementa la fecha en un mes
            }
            return month;
        }
        private List<int> GetYearPayment(Cursada cursada)
        {
            List<int> year = new List<int>();

            DateTime fechaInicio = cursada.Initiation; // Fecha de inicio
            DateTime fechaFin = cursada.Finish; // Fecha de fin

            while (fechaInicio <= fechaFin)
            {
                year.Add(fechaInicio.Year); // Agrega el año a la lista
                fechaInicio = fechaInicio.AddMonths(1); // Incrementa la fecha en un mes
            }
            return year;
        }
    }
}
