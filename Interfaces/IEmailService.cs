namespace foodtopia.Interfaces
{
    public interface IEmailService
    {
        Task SendEmailConfirmationAsync(string recipientEmail, string confirmationLink);
    }
}