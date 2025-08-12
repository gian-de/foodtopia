namespace foodtopia.Interfaces
{
    public interface IEmailService
    {
        Task SendEmailAsync(string recipientEmail, string subject, string htmlBody);
        Task SendEmailConfirmationAsync(string recipientEmail, string confirmationLink);
        Task SendEmailPasswordResetAsync(string recipientEmail, string passwordResetLink);
        Task SendEmailUsernameInfoAsync(string recipientEmail, string username);
    }
}