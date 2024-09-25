namespace SchoolMusic.Entidades
{
    public class Notification
    {
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


        public Notification()
        {
        }
    }
}
