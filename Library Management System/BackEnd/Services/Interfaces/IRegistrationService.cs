using BackEnd.Models.Constants;
using BackEnd.Models.Entities;

namespace BackEnd.Services.Interfaces;

public interface IRegistrationService
{
    (User UserInfo, UserCredentials UserCredentials)? RegisterUser(string name, 
        string lastName, string email, string username, string password, 
        RoleOfUser userRole, out string errorMessage);

    (User UserInfo, UserCredentials UserCredentials)? SignIn(string username, string password);
}