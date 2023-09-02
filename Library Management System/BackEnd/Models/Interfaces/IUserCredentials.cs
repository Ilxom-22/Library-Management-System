namespace BackEnd.Models.Interfaces;

public interface IUserCredentials
{
    string Email { get; set; }
    string UserName { get; set; }
    string Password { get; set; }
    DateTime ActiveSince { get; set; }
}