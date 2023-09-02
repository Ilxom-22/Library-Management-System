using BackEnd.DataLayer.Context;
using BackEnd.Models.Entities;
using BackEnd.Services.Interfaces;

namespace BackEnd.Services.Service;

public class BookAndGenreRelationService : IBookAndGenreRelationService
{
    private readonly AppDataContext _context;

    public BookAndGenreRelationService(AppDataContext context)
    {
        _context = context;
    }

    public void AddGenreRelations(int bookId, List<int> genresId)
    {
        foreach (var genreId in genresId)
        {
            var relation = new BookAndGenre(bookId, genreId);
            _context.BookAndGenres.Add(relation);
        }
        _context.BookAndGenres.SaveChanges();
    }

    public void RemoveGenreRelations(int bookId)
    {
        foreach (var relation in GetRelations(bookId))
            _context.BookAndGenres.Remove(relation);

        _context.BookAndGenres.SaveChanges();
    }

    public List<int> GetGenresId(int bookId)
       => GetRelations(bookId)
            .Select(relation => relation.GenreId)
            .ToList();

    public bool GenreHasRelatedBooks(int genreId)
        => _context.BookAndGenres.Any(relation => relation.GenreId == genreId);

    private List<BookAndGenre> GetRelations(int bookId)
         => _context.BookAndGenres
                .Where(item => item.BookId == bookId)
                .ToList();
}