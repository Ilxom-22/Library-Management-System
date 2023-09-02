namespace BackEnd.Services.Interfaces;

public interface IMessageTemplatesService
{
    string WelcomeReaderSubject(string readerName);
    string WelcomeReaderBody(string readerName);
}