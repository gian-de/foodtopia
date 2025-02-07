using System.Net;
using System.Net.Mail;

namespace foodtopia.Services
{
    public class EmailService
    {
        public async Task SendEmailConfirmation(string emailReceptor, string confirmationLink)
        {
            var email = Environment.GetEnvironmentVariable("GMAIL_EMAIL");
            var password = Environment.GetEnvironmentVariable("GMAIL_PASSWORD");
            var host = "smtp.gmail.com";
            var port = 587;

            var smtpClient = new SmtpClient(host, port);
            smtpClient.EnableSsl = true;
            smtpClient.UseDefaultCredentials = false;

            smtpClient.Credentials = new NetworkCredential(email, password);

            var message = new MailMessage(email!, emailReceptor);
            await smtpClient.SendMailAsync(message);
        }
    }
}