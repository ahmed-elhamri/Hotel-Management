using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Management.Services
{
    public class EmailMessage
    {
        public string To { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
    }

    public static class EmailService
    {
        private static readonly string SmtpServer = "smtp.gmail.com";
        private static readonly int SmtpPort = 587;
        private static readonly string Username = "elhamri949@gmail.com";
        private static readonly string Password = "aqys zozs avrl uzir";
        private static readonly bool EnableSsl = true;

        public static void SendEmail(EmailMessage message)
        {
            var smtp = new SmtpClient(SmtpServer, SmtpPort)
            {
                Credentials = new System.Net.NetworkCredential(Username, Password),
                EnableSsl = EnableSsl
            };

            var mailMessage = new MailMessage("contact.hotelmanagement@gmail.com", message.To)
            {
                Subject = message.Subject,
                Body = message.Body,
                IsBodyHtml = true
            };

            smtp.Send(mailMessage);
        }
    }
}
