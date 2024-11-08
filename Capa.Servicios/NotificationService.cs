using Capa.Base.De.Datos;
using SchoolMusic.BD;
using SchoolMusic.Entidades;
using System.Data;

namespace SchoolMusic.Serv
{
    public class NotificationService
    {
        Dictionary<string, string> prm = new Dictionary<string, string>();
        List<Notification> listNotif = new List<Notification>();
        CnxSelect select = new CnxSelect();
        CnxAccion accion = new CnxAccion();
        Teacher teacher = new Teacher();
        Student student = new Student();

        public List<Notification> GetNotificationRecibidas(int idUser)
        {
            // Agrego parametros
            prm.Clear();
            prm.Add("@idUser", idUser.ToString());

            // Query
            string sqlQueryNotif = "SELECT * FROM Notification WHERE NotificationTo = @idUser";
            var dateNotif = select.SelectData(sqlQueryNotif, prm);

            if (dateNotif != null && dateNotif.Rows.Count > 0)
            {
                foreach (DataRow n in dateNotif.Rows)
                {
                    listNotif.Add(new Notification
                    {
                        IdNotification = int.Parse(n["IdNotifiStudent"].ToString()),
                        NotificationTo = int.Parse(n["NotificatinTo"].ToString()),
                        NotificationFrom = int.Parse(n["NotificationFrom"].ToString()),
                        Subject = n["Subject"].ToString(),
                        Body = n["Body"].ToString(),
                        DateNotification = Convert.ToDateTime(n["DateNotification"].ToString()),
                    });
                }
            }
            return listNotif;
        }
        public List<Notification> GetNotificationEnviadas(int idUser)
        {
            // Agrego parametros
            prm.Clear();
            prm.Add("@idUser", idUser.ToString());

            // Query
            string sqlQueryNotif = "SELECT * FROM Notification WHERE NotificationFrom = @idUser";
            var dateNotif = select.SelectData(sqlQueryNotif, prm);

            if (dateNotif != null && dateNotif.Rows.Count > 0)
            {
                foreach (DataRow n in dateNotif.Rows)
                {
                    listNotif.Add(new Notification
                    {
                        IdNotification = int.Parse(n["IdNotifiStudent"].ToString()),
                        NotificationTo = int.Parse(n["NotificatinTo"].ToString()),
                        NotificationFrom = int.Parse(n["NotificationFrom"].ToString()),
                        Subject = n["Subject"].ToString(),
                        Body = n["Body"].ToString(),
                        DateNotification = Convert.ToDateTime(n["DateNotification"].ToString()),
                    });
                }
            }
            return listNotif;
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
                var dateTeacher = select.SelectData(sqlQueryTeacher, prm).Rows[0];

                teacher = new()
                {
                    IdTeacher = int.Parse(dateTeacher["IdTeacher"].ToString()),
                    NameTeacher = dateTeacher["nombreCompleto"].ToString()
                };
            }
            catch (Exception e)
            {

                return null;
            }
            return teacher;
        }
        public Student GetStudent(int idStudent)
        {
            // Agrego parametros
            prm.Clear();
            prm.Add("@idStudent", idStudent.ToString());

            // Query
            string sqlQueryStudent = "SELECT IdStudent, CONCAT(NameStudent,' ', Surname) AS nombreCompleto FROM Student WHERE IdStudent = @idStudent";
            var dateStudent = select.SelectData(sqlQueryStudent, prm).Rows[0];

            student = new()
            {
                IdStudent = int.Parse(dateStudent["IdStudent"].ToString()),
                NameStudent = dateStudent["nombreCompleto"].ToString(),
            };

            return student;
        }
        public int SendNotification(Notification notification)
        {
            int result = 0;
            //Agrego parametros
            prm.Clear();
            prm.Add("@notificationTo", notification.NotificationTo.ToString());
            prm.Add("@notificationFrom", notification.NotificationFrom.ToString());
            prm.Add("@subject", notification.Subject);
            prm.Add("@body", notification.Body);


            // Query
            string sqlQueryNotif = "INSERT INTO Notification (NotificationTo, NotificationFrom, Subject, Body)" +
                "VALUES (@notificationTo, @notificationFrom, @subject, @body)";
            result = accion.AccionEjecutar(sqlQueryNotif, prm);
            
            return result;
        }
    }
}
