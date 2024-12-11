using Capa.Base.De.Datos;
using SchoolMusic.BD;
using SchoolMusic.Entidades;
using System.Data;

namespace SchoolMusic.Serv
{
    public class NotificationService
    {
        Dictionary<string, string> prm = new Dictionary<string, string>();
        CnxSelect select = new CnxSelect();
        CnxAccion accion = new CnxAccion();
        Teacher teacher = new Teacher();
        Student student = new Student();

        public List<Notification> GetNotificationRecibidas(int idUser)
        {
            // Lista de recibidos
            var listRecibidos = new List<Notification>();

            // Agrego parametros
            prm.Clear();
            prm.Add("@idUser", idUser.ToString());

            try
            {
                // Query
                string sqlQueryNotif = "SELECT * FROM Notification WHERE NotificationTo = @idUser";
                var dateNotification = select.SelectData(sqlQueryNotif, prm);

                if (dateNotification != null && dateNotification.Rows.Count > 0)
                {
                    foreach (DataRow n in dateNotification.Rows)
                    {
                        listRecibidos.Add(new Notification
                        {
                            IdNotification = int.Parse(n["IdNotification"].ToString()),
                            NotificationTo = int.Parse(n["NotificationTo"].ToString()),
                            NotificationFrom = int.Parse(n["NotificationFrom"].ToString()),
                            Subject = n["Subject"].ToString(),
                            Body = n["Body"].ToString(),
                            DateNotification = Convert.ToDateTime(n["DateNotification"].ToString()),
                        });
                    }
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine("Error: " + ex.Message);
            }
            return listRecibidos;
        }
        public List<Notification> GetNotificationEnviadas(int idUser)
        {
            // Lista de recibidos
            var listEnviados = new List<Notification>();
            // Agrego parametros
            prm.Clear();
            prm.Add("@idUser", idUser.ToString());

            try
            {
                // Query
                string sqlQueryNotif = "SELECT * FROM Notification WHERE NotificationFrom = @idUser";
                var dateNotification = select.SelectData(sqlQueryNotif, prm);

                if (dateNotification != null && dateNotification.Rows.Count > 0)
                {
                    foreach (DataRow n in dateNotification.Rows)
                    {
                        listEnviados.Add(new Notification
                        {
                            IdNotification = int.Parse(n["IdNotification"].ToString()),
                            NotificationTo = int.Parse(n["NotificationTo"].ToString()),
                            NotificationFrom = int.Parse(n["NotificationFrom"].ToString()),
                            Subject = n["Subject"].ToString(),
                            Body = n["Body"].ToString(),
                            DateNotification = Convert.ToDateTime(n["DateNotification"].ToString()),
                        });
                    }
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine("Error: " + ex.Message);
            }
            return listEnviados;
        }
        public Teacher GetTeacher(int idTeacher)
        {
            // Agrego parametros
            prm.Clear();
            prm.Add("@idTeacher", idTeacher.ToString());

            // Query
            string sqlQueryTeacher = "SELECT IdTeacher, CONCAT('Prof.',NameTeacher,' ', Surname) AS nombreCompleto FROM Teacher WHERE IdTeacher = @idTeacher";
            try
            {
                var dateTeacher = select.SelectData(sqlQueryTeacher, prm);

                if (dateTeacher.Rows.Count > 0)
                {
                    var table = dateTeacher.Rows[0];
                    teacher = new()
                    {
                        IdTeacher = int.Parse(table["IdTeacher"].ToString()),
                        NameTeacher = table["nombreCompleto"].ToString()
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
    }
}
