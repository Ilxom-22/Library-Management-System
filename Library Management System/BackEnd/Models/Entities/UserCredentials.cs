using BackEnd.Models.Common;
using BackEnd.Models.Interfaces;

namespace BackEnd.Models.Entities;

public class UserCredentials : IEntity, IUserCredentials, ICopyable<UserCredentials>
{
    public UserCredentials(string email, string username, string password, int userId)
    {
        Email = email;
        UserName = username;
        Password = password;
        ActiveSince = DateTime.Now;
        UserId = userId;
    }

    private UserCredentials(UserCredentials userCredentials)
    {
        Id = userCredentials.Id;
        Email = userCredentials.Email;
        UserName = userCredentials.UserName;
        Password = userCredentials.Password;
        ActiveSince = userCredentials.ActiveSince;
        UserId = userCredentials.UserId;
    }

    public int Id { get; set; }
    public string Email { get; set; }
    public string UserName { get; set; }
    public string Password { get; set; }
    public DateTime ActiveSince { get; set; }
    public int UserId { get; set; }

    public UserCredentials Copy()
    {
        return new UserCredentials(this);
    }
}