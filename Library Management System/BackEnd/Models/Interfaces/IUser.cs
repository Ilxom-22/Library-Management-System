using BackEnd.Models.Constants;

namespace BackEnd.Models.Interfaces;

public interface IUser
{
    string Name { get; set; }
    string LastName { get; set; }
    string FullName { get; }
    RoleOfUser UserRole { get; set; }
}