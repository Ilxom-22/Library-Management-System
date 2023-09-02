using BackEnd.Models.Common;

namespace BackEnd.Models.Entities;

public class Author : IEntity, ICopyable<Author>
{
    public Author(string name, string lastName, string biography, DateTime dateOfBirth, DateTime? dateOfDeath)
    {
        Name = name;
        LastName = lastName;
        Biography = biography;
        DateOfBirth = dateOfBirth;
        DateOfDeath = dateOfDeath;
    }

    private Author(Author author)
    {
        Id = author.Id;
        Name = author.Name;
        LastName = author.LastName;
        Biography = author.Biography;
        DateOfBirth = author.DateOfBirth;
        DateOfDeath = author.DateOfDeath;
    }

    public int Id { get; set; }
    public string Name { get; set; }
    public string LastName { get; set; }
    public string FullName => $"{Name} {LastName}";
    public string Biography { get; set; }
    public DateTime DateOfBirth { get; set; }
    public DateTime? DateOfDeath { get; set; }

    public Author Copy()
    {
        return new Author(this);
    }

    public override int GetHashCode()
    {
        int hash = 17;
        hash = hash * 23 + FullName.GetHashCode();
        hash = hash * 23 + DateOfBirth.GetHashCode();
        return hash;
    }

    public override bool Equals(object? obj)
    {
        if (obj != null && obj is Author)
            return GetHashCode() == obj.GetHashCode();

        return false;
    }

    public override string ToString()
    {
        return FullName;
    }
}