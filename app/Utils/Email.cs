﻿using System.Net;
using System.Net.Mail;
using System.Net.Mime;

namespace SystemGymControl
{
    class Email
    {
        public static void Submit(string recipient, string subject, string file, string message)
        {

            string email = Security.Dry("wfgouppjwOtnoQ2r6PbI6XbU0gP0Wt7rG0+g9GOZn1Q="),
                senha = Security.Dry("2JsPTOhfvnzvRQVcZdYQyQ==");

            try
            {
                AlternateView alternate = AlternateView.CreateAlternateViewFromString(message, null, MediaTypeNames.Text.Html);
                SmtpClient smtp = new SmtpClient();
               

                smtp.Host = "smtp.live.com";
                smtp.Port = 587;
                smtp.EnableSsl = true;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new NetworkCredential(email, senha);

                MailMessage mail = new MailMessage();
                mail.AlternateViews.Add(alternate);
                mail.From = new MailAddress(email);

                mail.Attachments.Add(new Attachment(file));

                mail.To.Add(new MailAddress(recipient));
                mail.Subject = subject;
                mail.Body = message;
                smtp.Send(mail);
            }
            catch
            {
                throw;
            }
        }
    }
}
