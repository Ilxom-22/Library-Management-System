using BackEnd.Models.Common;
using BackEnd.Models.Constants;
using BackEnd.Models.Interfaces;

namespace BackEnd.Models.Entities;

public class User : IEntity, IUser, ICopyable<User>
{
    public User(string name, string lastName, RoleOfUser userRole)
    {
        Name = name;
        LastName = lastName;
        UserRole = userRole;
    }

    private User(User user)
    {
        Id = user.Id;
        Name = user.Name;
        LastName = user.LastName;
        UserRole = user.UserRole;
    }

    public int Id { get; set; }
    public string Name { get; set; }
    public string LastName { get; set; }
    public string FullName => $"{Name} {LastName}";
    public RoleOfUser UserRole { get; set; }


    public User Copy()
    {
        return new User(this);
    }
}