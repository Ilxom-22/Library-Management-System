using BackEnd.Services.Interfaces;
using System.Net.Mail;
using System.Net;

namespace BackEnd.Services.Service;

public class EmailService : IEmailService
{
    public void SendEmailAsync(string subject, string body, string receiverEmail)
    {
        var senderEmail = "samsung6771157@gmail.com";
        var senderPassword = "gvmjcmhfrhfozrcs";

        var mail = new MailMessage(senderEmail, receiverEmail);
        mail.Subject = subject;
        mail.Body = body;

        var smtpClient = new SmtpClient("smtp.gmail.com", 587);
        smtpClient.Credentials = new NetworkCredential(senderEmail, senderPassword);
        smtpClient.EnableSsl = true;

        smtpClient.SendAsync(mail, null);
    }
}