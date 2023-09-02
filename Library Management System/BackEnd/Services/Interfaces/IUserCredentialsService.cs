using BackEnd.Models.Entities;

namespace BackEnd.Services.Interfaces;

public interface IUserCredentialsService
{
    UserCredentials AddCredential(string email, string username, string password, int userId);
    string? CredentialExists(string email, string username);
    UserCredentials? FindUser(string username);
    string GetUsernameOfUser(int userId);
}