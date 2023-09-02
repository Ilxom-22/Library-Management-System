using BackEnd.DataLayer.Context;
using BackEnd.Models.Constants;
using BackEnd.Models.Entities;
using BackEnd.Services.Interfaces;

namespace BackEnd.Services.Service;

public class UserService : IUserService
{
    private readonly AppDataContext _context;

    public UserService(AppDataContext context)
    {
        _context = context;
    }

    public User AddUser(string name, string lastName, RoleOfUser userRole)
    {
        var user = new User(name, lastName, userRole);
        _context.Users.Add(user);
        _context.Users.SaveChanges();
        return user.Copy();
    }

    public User? FindUser(int userId)
        => _context.Users.FirstOrDefault(user => user.Id == userId)?.Copy();

    public int GetAllReadersCount()
        => _context.Users.Where(user => user.UserRole == RoleOfUser.Reader).Count();

    public bool LibrarianExists()
        => _context.Users.Any(user => user.UserRole == RoleOfUser.Librarian);

    public bool UserExists(int userId)
        => _context.Users.Any(user => user.Id == userId);
}