using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa.Entidades
{
    public class MailSettings
    {
        public string server {  get; set; } // Nombre del servidor
        public int port { get; set; } // Número de puerto
        public string fromName {  get; set; } // Nombre de quien está enviando el corréo
        public string fromMail {  get; set; } // Email del que está enviando el mensaje
        public string userName { get; set; } // Nombre de usuario
        public string password { get; set; } // Contraseña del email

        public MailSettings(string server, int port, string fromName, string fromMail, string userName, string password)
        {
            this.server = server;
            this.port = port;
            this.fromName = fromName;
            this.fromMail = fromMail;
            this.userName = userName;
            this.password = password;
        }
    }
}
