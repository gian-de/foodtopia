using System.Net;
using System.Net.Mail;
using foodtopia.Interfaces;

namespace foodtopia.Services
{
    public class EmailService : IEmailService
    {
        public async Task SendEmailAsync(string recipientEmail, string subject, string htmlBody)
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
                From = new MailAddress("noreply@foodtopia.com", "Foodtopia"),
                Subject = subject,
                Body = htmlBody,
                IsBodyHtml = true
            };

            message.To.Add(recipientEmail);
            await smtpClient.SendMailAsync(message);
        }

        public Task SendEmailConfirmationAsync(string recipientEmail, string confirmationLink)
        {
            string subject = "FOODTOPIA - Confirm Your Email";
            string htmlBody = $"<h1>Please confirm your email by clicking <a href='{confirmationLink}'>here.</a></h1>";

            return SendEmailAsync(recipientEmail, subject, htmlBody);
        }

        public Task SendEmailPasswordResetAsync(string recipientEmail, string passwordResetLink)
        {
            string subject = "FOODTOPIA - Reset Password";
            string htmlBody = $"<h1>Reset your password by clicking <a href='{passwordResetLink}'>here.</a></h1>";

            return SendEmailAsync(recipientEmail, subject, htmlBody);
        }

        public Task SendEmailUsernameInfoAsync(string recipientEmail, string username)
        {
            string subject = "FOODTOPIA - Forgot Username";
            string htmlBody = $"<p>Your login username is: <strong>{username}<strong></p>";

            return SendEmailAsync(recipientEmail, subject, htmlBody);
        }
    }
}