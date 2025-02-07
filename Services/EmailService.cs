using System.Net;
using System.Net.Mail;
using foodtopia.Interfaces;

namespace foodtopia.Services
{
    public class EmailService : IEmailService
    {
        public async Task SendEmailConfirmationAsync(string recipientEmail, string confirmationLink)
        {
            var senderEmail = Environment.GetEnvironmentVariable("GMAIL_EMAIL");
            var password = Environment.GetEnvironmentVariable("GMAIL_PASSWORD");
            var host = "smtp.gmail.com";
            var port = 587; // TLS port number
            // var port = 465; // SSL port number

            using var smtpClient = new SmtpClient(host, port)
            {
                EnableSsl = true,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(senderEmail, password)
            };

            var message = new MailMessage
            {
                From = new MailAddress(senderEmail),
                Subject = "Confirm Your Email - FOODTOPIA",
                Body = $"Please confirm your email by clicking <a href='{confirmationLink}'>here</a>.",
                IsBodyHtml = true
            };

            message.To.Add(recipientEmail);
            await smtpClient.SendMailAsync(message);
        }
    }
}