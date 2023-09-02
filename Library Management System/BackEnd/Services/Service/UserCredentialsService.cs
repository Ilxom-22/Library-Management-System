using BackEnd.DataLayer.Context;
using BackEnd.Models.Entities;
using BackEnd.Services.Interfaces;

namespace BackEnd.Services.Service;

public class UserCredentialsService : IUserCredentialsService
{
    private readonly AppDataContext _context;

    public UserCredentialsService(AppDataContext context)
    {
        _context = context;
    }

    public UserCredentials AddCredential(string email, string username, string password, int userId)
    {
        var credential = new UserCredentials(email, username, password, userId);
        _context.UserCredentials.Add(credential);
        _context.UserCredentials.SaveChanges();

        return credential.Copy();
    }

    public string? CredentialExists(string email, string username)
    {
        if (_context.UserCredentials.Any(user => user.Email.Equals(email)))
            return "Email Address is already Registrated.";

        if (_context.UserCredentials.Any(user => user.UserName.Equals(username)))
            return "Username is already taken!";

        return null;
    }

    public UserCredentials? FindUser(string username)
        => _context.UserCredentials
                .FirstOrDefault(user => user.UserName == username)?.Copy();

    public string GetUsernameOfUser(int userId)
    {
        var userCredential = _context.UserCredentials.FirstOrDefault(user => user.UserId == userId);
        if (userCredential == null)
            throw new InvalidOperationException();

        return userCredential.UserName;
    }
}