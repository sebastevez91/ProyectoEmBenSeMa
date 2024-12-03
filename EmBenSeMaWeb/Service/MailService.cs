using Capa.Entidades;
using Microsoft.Extensions.Options;
using System.Net.Mail;
using System.Net;

namespace SchoolMusic.Web.Service
{
    public class MailService
    {
        private readonly MailSettings _settingsMail;

        public MailService(IOptions<MailSettings> settings)
        {
            _settingsMail = settings.Value;
        }

        public void sendMail(MailData mailData)
        {
            var mail = new MailMessage();
            mail.To.Add(mailData.mailTo);
            mail.Subject = mailData.subject;
            mail.From = new MailAddress(_settingsMail.fromMail, _settingsMail.fromName);
            mail.IsBodyHtml = true;
            mail.Body = mailData.body;

            var client = new SmtpClient
            {
                Host = _settingsMail.server,
                Port = _settingsMail.port,
                Credentials = new NetworkCredential(_settingsMail.userName, _settingsMail.password),
                EnableSsl = true
            };

            client.Send(mail);
            client.Dispose();
        }
    }
}
