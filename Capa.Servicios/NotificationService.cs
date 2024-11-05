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

        public List<Notification> GetNotificationStudent(int idStudent)
        {
            // Agrego parametros
            prm.Clear();
            prm.Add("@idStudent", idStudent.ToString());

            // Query
            string sqlQueryNotif = "SELECT * FROM NotifiStudent WHERE IdStudent = @idStudent";
            var dateNotif = select.SelectData(sqlQueryNotif, prm);

            if (dateNotif != null && dateNotif.Rows.Count > 0)
            {
                foreach (DataRow n in dateNotif.Rows)
                {
                    //listNotif.Add(new Notification
                    //{
                    //    idNotification = int.Parse(n["IdNotifiStudent"].ToString()),
                    //    idStudent = int.Parse(n["IdStudent"].ToString()),
                    //    tipo = n["Tipo"].ToString(),
                    //    subject = n["Subject"].ToString(),
                    //    body = n["Body"].ToString(),
                    //    dateNotification = Convert.ToDateTime(n["DateNotification"].ToString()),
                    //    idTeacher = int.Parse(n["IdTeacher"].ToString())
                    //});
                }
            }
            return listNotif;
        }
        public List<Notification> GetNotificationTeacher(int idTeacher)
        {
            // Agrego parametros
            prm.Clear();
            prm.Add("@idTeacher", idTeacher.ToString());

            // Query
            string sqlQueryNotif = "SELECT * FROM NotifiTeacher WHERE IdTeacher = @idTeacher";
            var dateNotif = select.SelectData(sqlQueryNotif, prm);

            if (dateNotif != null && dateNotif.Rows.Count > 0)
            {
                foreach (DataRow n in dateNotif.Rows)
                {
                    //listNotif.Add(new Notification()
                    //{
                    //    idNotification = int.Parse(n["IdNotifiTeacher"].ToString()),
                    //    idTeacher = int.Parse(n["IdTeacher"].ToString()),
                    //    tipo = n["Tipo"].ToString(),
                    //    subject = n["Subject"].ToString(),
                    //    body = n["Body"].ToString(),
                    //    dateNotification = Convert.ToDateTime(n["DateNotification"].ToString()),
                    //    idStudent = int.Parse(n["IdStudent"].ToString())
                    //});
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

                //MessageBox.Show("Error " + e.Message);
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
        public void SendNotifiStudent(Notification notification)
        {
            int result = 0;
            // Agrego parametros
            //prm.Clear();
            //prm.Add("@idStudent", notification.idStudent.ToString());
            //prm.Add("@idTeacher", notification.idTeacher.ToString());
            //prm.Add("@tipo", "Envio");
            //prm.Add("@subject", notification.subject);
            //prm.Add("@body", notification.body);


            // Query
            string sqlQueryNotif = "INSERT INTO NotifiStudent (IdStudent, Tipo, Subject, Body, IdTeacher)" +
                "VALUES (@idStudent, @tipo, @subject, @body, @idTeacher)";
            result = accion.AccionEjecutar(sqlQueryNotif, prm);
            if (result > 0)
            {
                ArchivoTeacher(notification,prm);
                //MessageBox.Show("Mensaje enviado");
            }
            else
            {
                //MessageBox.Show("No se pudo mandar el mensaje");
            }
        }
        private void ArchivoStudent(Notification notification, Dictionary<string, string> parametro)
        {
            int result = 0;
            // Agrego parametros
            //prm.Clear();
            //prm.Add("@idStudent", notification.idStudent.ToString());
            //prm.Add("@idTeacher", notification.idTeacher.ToString());
            //prm.Add("@tipo", "Recepción");
            //prm.Add("@subject", notification.subject);
            //prm.Add("@body", notification.body);


            // Query
            string sqlQueryNotif = "INSERT INTO NotifiStudent (IdStudent, Tipo, Subject, Body, IdTeacher)" +
                "VALUES (@idStudent, @tipo, @subject, @body, @idTeacher)";
            result = accion.AccionEjecutar(sqlQueryNotif, prm);
        }
        public void SendNotifiTeacher(Notification notification)
        {
            int result = 0;
            // Agrego parametros
            //prm.Clear();
            //prm.Add("@idTeacher", notification.idTeacher.ToString());
            //prm.Add("@idStudent", notification.idStudent.ToString());
            //prm.Add("@tipo", "Envio");
            //prm.Add("@subject", notification.subject);
            //prm.Add("@body", notification.body);

            // Query
            string sqlQueryNotif = "INSERT INTO NotifiTeacher (IdTeacher, Tipo, Subject, Body, IdStudent)" +
                "VALUES (@idTeacher, @tipo, @subject, @body, @idStudent)";
            result = accion.AccionEjecutar(sqlQueryNotif, prm);
            if (result > 0)
            {
                ArchivoStudent(notification, prm);
                //MessageBox.Show("Mensaje enviado");
            }
            else
            {
                //MessageBox.Show("No se pudo mandar el mensaje");
            }
        }
        private void ArchivoTeacher(Notification notification, Dictionary<string, string> parametro)
        {
            int result = 0;
            // Agrego parametros
            //prm.Clear();
            //prm.Add("@idTeacher", notification.idTeacher.ToString());
            //prm.Add("@idStudent", notification.idStudent.ToString());
            //prm.Add("@tipo", "Recepción");
            //prm.Add("@subject", notification.subject);
            //prm.Add("@body", notification.body);


            // Query
            string sqlQueryNotif = "INSERT INTO NotifiTeacher (IdTeacher, Tipo, Subject, Body, IdStudent)" +
                "VALUES (@idTeacher, @tipo, @subject, @body, @idStudent)";
            result = accion.AccionEjecutar(sqlQueryNotif, prm);
        }
    }
}
