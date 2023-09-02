namespace BackEnd.Services.Interfaces;

public interface IEmailService
{
    void SendEmailAsync(string subject, string body, string receiverEmail);
}