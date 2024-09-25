﻿using Capa.Entidades;
using System.Collections.Specialized;
using System.Configuration;
using System.Net;
using System.Net.Http;
using System.Net.Mail;

namespace Capa.Servicios
{
    public class MailService
    {
        MailSettings settingsMail;

        public MailService()
        {
            var section = (NameValueCollection)ConfigurationManager.GetSection("MailSettings");
            settingsMail = new MailSettings(
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
            mail.From = new MailAddress(settingsMail.fromMail, settingsMail.fromName);
            mail.IsBodyHtml = true;
            mail.Body = mailData.body;

            // Nos conectamos a Gmail

            var client = new SmtpClient();
            client.Host = settingsMail.server;
            client.Port = settingsMail.port;
            client.Credentials = new NetworkCredential(settingsMail.userName, settingsMail.password);
            client.UseDefaultCredentials = false;
            client.EnableSsl = true;

            // Enviamos correo

            client.Send(mail);

            // Nos desconectamos del Gmail

            client.Dispose();
        }
    }
}
