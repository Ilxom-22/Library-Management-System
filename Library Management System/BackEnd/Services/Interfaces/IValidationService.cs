namespace BackEnd.Services.Interfaces;

public interface IValidationService
{
    string? CheckUsername(string username);
    bool CheckEmailAddress(string emailAddress);
    string? CheckPassword(string password);
    bool CheckName(ref string name);
    bool CheckLastName(ref string lastName);
    string? CheckGenreName(string genreName);
}