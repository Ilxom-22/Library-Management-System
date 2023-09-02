using BackEnd.Models.Common;

namespace BackEnd.Models.Entities;

public class Genre : IEntity, ICopyable<Genre>
{
    public Genre(string name)
    {
        Name = name;
    }

    private Genre(Genre genre)
    {
        Id = genre.Id;
        Name = genre.Name;
    }

    public int Id { get; set; }
    public string Name { get; set; }


    public Genre Copy()
    {
       return new Genre(this);
    }

    public override string ToString()
    {
        return Name;
    }
}