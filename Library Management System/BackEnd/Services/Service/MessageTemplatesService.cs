using BackEnd.Models.Constants;
using BackEnd.Services.Interfaces;

namespace BackEnd.Services.Service;

public class MessageTemplatesService : IMessageTemplatesService
{
    public string WelcomeReaderSubject(string readerName)
        => MailMerge(MessageConstants.WelcomeReaderSubject, readerName);
           
    public string WelcomeReaderBody(string readerName)
        => MailMerge(MessageConstants.WelcomeReaderBody, readerName);

    private string MailMerge(string message, string username)
        => message
             .Replace(MessageConstants.LibraryNameToken, MessageConstants.LibraryName)
             .Replace(MessageConstants.UserToken, username);
}