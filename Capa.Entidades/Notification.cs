using System.ComponentModel.DataAnnotations;

namespace SchoolMusic.Entidades
{
    public class Notification
    {
        [Key]
        public int IdNotification { get; set; }
        public int NotificationTo { get; set; }
        public int NotificationFrom { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public DateTime DateNotification { get; set; }


        public Notification()
        {
        }
    }
}
