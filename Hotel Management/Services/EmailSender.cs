using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Management.Services
{
    class EmailSender
    {
        public static class EmailConfiguration
        {
            public static string SmtpServer { get; set; } = "smtp.gmail.com";
            public static int SmtpPort { get; set; } = 465;
            public static string Email { get; set; } = "elhamriahmed41@gmail.com";
            public static string Password { get; set; } = "ahmedelhamri@41";
            public static bool EnableSsl { get; set; } = true;
        }
        public static void Send(string toEmail, string text)
        {
            try
            {
                using (var smtpClient = new SmtpClient(EmailConfiguration.SmtpServer, EmailConfiguration.SmtpPort))
                {
                    smtpClient.Credentials = new NetworkCredential(EmailConfiguration.Email, EmailConfiguration.Password);
                    smtpClient.EnableSsl = EmailConfiguration.EnableSsl;

                    var mailMessage = new MailMessage
                    {
                        From = new MailAddress(EmailConfiguration.Email),
                        Subject = "Message automatique",
                        Body = text,
                        IsBodyHtml = false 
                    };

                    mailMessage.To.Add(toEmail);

                    smtpClient.Send(mailMessage);
                    Console.WriteLine("E-mail envoyé avec succès à " + toEmail);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erreur lors de l'envoi de l'e-mail à {toEmail} : {ex.Message}");
                throw;
            }
        }   
    }
}
