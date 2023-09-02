using BackEnd.Models.Common;

namespace BackEnd.Models.Entities;

public class BookAndGenre : IEntity
{
    public BookAndGenre(int bookId, int genreId)
    {
        BookId = bookId;
        GenreId = genreId;
    }

    public int Id { get; set; }
    public int BookId { get; set; }
    public int GenreId { get; set; }
}