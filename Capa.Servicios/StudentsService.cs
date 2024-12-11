using Capa.Base.De.Datos;
using SchoolMusic.BD;
using SchoolMusic.Entidades;
using System.Data;

namespace SchoolMusic.Serv
{

    public class StudentsService
    {
        Dictionary<string, string> prm = new Dictionary<string, string>();
        private CnxAccion accion = new CnxAccion();
        private CnxSelect select = new CnxSelect();
        private Student student;

        public Student GetStudent(int id)
        {
            // Agrego parámetros
            prm.Clear();
            prm.Add("@idUser", id.ToString());

            try
            {
                // Query
                string sqlQueryStudent = "SELECT * FROM Student WHERE IdUser = @idUser";

                var resultTable = select.SelectData(sqlQueryStudent, prm);

                // Verifica si hay filas antes de acceder
                if (resultTable.Rows.Count > 0)
                {
                    var table = resultTable.Rows[0];

                    student = new Student()
                    {
                        IdStudent = int.Parse(table["IdStudent"].ToString()),
                        NameStudent = table["NameStudent"].ToString(),
                        Surname = table["Surname"].ToString(),
                        Mail = table["Mail"].ToString(),
                        Dni = int.Parse(table["Dni"].ToString()),
                        Age = int.Parse(table["Age"].ToString()),
                        IdUser = int.Parse(table["IdUser"].ToString()),
                        Genero = table["Genero"].ToString()
                    };
                }
                else
                {
                    // No hay resultados, asigna null a student
                    student = null;
                }
            }
            catch (Exception ex)
            {
                // Log o manejo de excepciones si es necesario
                Console.WriteLine("Error: " + ex.Message);
                student = null;
            }

            return student;
        }
        public List<Cursada> GetListCursada(int id)
        {
            List<Inscription> listInscription = new List<Inscription>();
            List<Cursada> listCursada = new List<Cursada>();
            // Agrego parametros
            prm.Clear();
            prm.Add("@idStudent", id.ToString());

            // Query
            string sqlQueryInscription = "SELECT IdCursada FROM Inscription WHERE IdStudent = @idStudent";
            var dataInscription = select.SelectData(sqlQueryInscription, prm);

            if (dataInscription != null && dataInscription.Rows.Count > 0)
            {
                foreach (DataRow ins in dataInscription.Rows)
                {
                    listInscription.Add(new Inscription()
                    {
                        idCursada = int.Parse(ins["IdCursada"].ToString()),
                    });
                }

                foreach (Inscription i in listInscription)
                {
                    listCursada.Add(GetCursada(i.idCursada));
                }
            }
            return listCursada;
        }
        public Course GetCourse(int id)
        {
            Course course = null;

            // Agrego parametros
            prm.Clear();
            prm.Add("@idCourse", id.ToString());

            try
            {
                // Query
                string sqlQueryCourse = "SELECT IdCourse, CONCAT('Cursada de ', Instrument) AS NameCourse FROM Course WHERE IdCourse = @idCourse";
                var dataCourse = select.SelectData(sqlQueryCourse, prm);
                // Verifica si hay filas antes de acceder
                if (dataCourse.Rows.Count > 0)
                {
                    var table = dataCourse.Rows[0];
                    course = new Course()
                    {
                        IdCourse = int.Parse(table["IdCourse"].ToString()),
                        Instrument = table["NameCourse"].ToString(),
                    };
                }
            }
            catch (Exception e)
            {

                Console.WriteLine("Error: " + e.Message);
            }
            return course;
        }
        private Cursada GetCursada(int id)
        {
            Cursada cursada = new Cursada();
            // Agrego parametros
            prm.Clear();
            prm.Add("@idCursada", id.ToString());

            try
            {
                // Query
                string sqlQueryCursada = "SELECT * FROM Cursada WHERE IdCursada = @idCursada";
                var dataCursada = select.SelectData(sqlQueryCursada, prm);
                if (dataCursada.Rows.Count > 0)
                {
                    var table = dataCursada.Rows[0];
                    cursada = new()
                    {
                        IdCursada = int.Parse(table["IdCursada"].ToString()),
                        IdCourse = int.Parse(table["IdCourse"].ToString()),
                        Initiation = Convert.ToDateTime(table["Initiation"].ToString()),
                        Finish = Convert.ToDateTime(table["Finish"].ToString()),
                        IdTeacher = int.Parse(table["IdTeacher"].ToString()),
                        StarTime = Convert.ToDateTime(table["StarTime"].ToString()),
                        EndTime = Convert.ToDateTime(table["EndTime"].ToString()),
                        Vacantes = int.Parse(table["Vacantes"].ToString()),
                        Days = table["Days"].ToString()
                    };
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine("Error: " + ex.Message);
                cursada = null;
            }
            return cursada;
        }
        public Teacher GetTeacher(int idTeacher)
        {
            Teacher teacher = new Teacher();
            // Agrego parametros
            prm.Clear();
            prm.Add("@idTeacher", idTeacher.ToString());

            try
            {
                // Query
                string sqlQueryTeacher = "SELECT * FROM Teacher WHERE IdTeacher = @idTeacher";
                var dataTeacher = select.SelectData(sqlQueryTeacher, prm);

                if (dataTeacher.Rows.Count > 0)
                {
                    var table = dataTeacher.Rows[0];
                    teacher = new()
                    {
                        IdTeacher = int.Parse(table["IdTeacher"].ToString()),
                        NameTeacher = table["NameTeacher"].ToString(),
                        Surname = table["Surname"].ToString(),
                        Mail = table["Mail"].ToString(),
                        Dni = int.Parse(table["Dni"].ToString()),
                        Age = int.Parse(table["Age"].ToString()),
                        IdUser = int.Parse(table["IdUser"].ToString()),
                        Genero = table["Genero"].ToString()
                    }; 
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine("Error: " + ex.Message);
                teacher = null;
            }
            return teacher;
        }
        public bool SendNotification(Notification notification)
        {
            prm.Clear();
            prm.Add("@notificationTo", notification.NotificationTo.ToString());
            prm.Add("@notificationFrom", notification.NotificationFrom.ToString());
            prm.Add("@subject", notification.Subject);
            prm.Add("@body", notification.Body);

            string sqlInsertNotification = @"INSERT INTO Notification (NotificationTo, NotificationFrom, Subject, Body, DateNotification, Status)
                        VALUES (@notificationTo, @notificationFrom, @subject, @body, GETDATE(), 0)";

            try
            {
                var result = accion.AccionEjecutar(sqlInsertNotification, prm);
                return result > 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al insertar la notificación: {ex.Message}");
                return false; // Retorna false si ocurre un error
            }
        }
    }
}
