using BackEnd.Models.Constants;
using BackEnd.Models.Entities;

namespace BackEnd.Services.Interfaces;

public interface IUserService
{
    User AddUser(string name, string lastName, RoleOfUser userRole);
    User? FindUser(int userId);
    bool LibrarianExists();
    int GetAllReadersCount();
    bool UserExists(int userId);
}