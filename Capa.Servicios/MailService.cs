using Capa.Entidades;
using System.Collections.Specialized;
using System.Configuration;
using System.Net;
using System.Net.Http;
using System.Net.Mail;

namespace Capa.Servicios
{
    public class MailService
    {
        MailSettings _settingsMail;

        public MailService()
        {
            var section = (NameValueCollection)ConfigurationManager.GetSection("MailSettings");
            _settingsMail = new MailSettings(
                    section["server"], int.Parse(section["port"]),
                    section["fromName"], section["fromMail"],
                    section["userName"], section["password"]
                );
        }
        public void sendMail(MailData mailData)
        {
            var mail = new MailMessage();
            mail.To.Add(mailData.mailTo);
            mail.Subject = mailData.subject;
            mail.From = new MailAddress(_settingsMail.fromMail, _settingsMail.fromName);
            mail.IsBodyHtml = true;
            mail.Body = mailData.body;

            // Nos conectamos a Gmail

            var client = new SmtpClient();
            client.Host = _settingsMail.server;
            client.Port = _settingsMail.port;
            client.Credentials = new NetworkCredential(_settingsMail.userName, _settingsMail.password);
            client.UseDefaultCredentials = false;
            client.EnableSsl = true;

            // Enviamos correo

            client.Send(mail);

            // Nos desconectamos del Gmail

            client.Dispose();
        }
    }
}
