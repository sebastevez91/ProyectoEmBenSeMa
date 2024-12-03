using System.ComponentModel.DataAnnotations;

namespace SchoolMusic.Entidades
{
    public class Notification
    {
        [Key]
<<<<<<< HEAD
        public int idNotification { get; set; }
        public int idStudent { get; set; }
        public int idTeacher { get; set; }
        public string tipo { get; set; }
        public string subject { get; set; }
        public string body { get; set; }
        public DateTime dateNotification { get; set; }

        public Notification(int idNotification,string tipo, int idStudent, int idTeacher, string subject, string body, DateTime dateNotification)
        {
            this.idNotification = idNotification;
            this.tipo = tipo;
            this.idStudent = idStudent;
            this.idTeacher = idTeacher;
            this.subject = subject;
            this.body = body;
            this.dateNotification = dateNotification;
        }
=======
        public int IdNotification { get; set; }
        public int NotificationTo { get; set; }
        public int NotificationFrom { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public DateTime DateNotification { get; set; }
<<<<<<< HEAD
>>>>>>> secondMain
=======
        public bool Status { get; set; }
>>>>>>> secondMain


        public Notification()
        {
        }
    }
}
