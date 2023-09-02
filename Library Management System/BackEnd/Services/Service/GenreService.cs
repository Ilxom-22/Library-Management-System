using BackEnd.DataLayer.Context;
using BackEnd.Models.Entities;
using BackEnd.Services.Interfaces;

namespace BackEnd.Services.Service;

public class GenreService : IGenreService
{
    private readonly AppDataContext _context;
    private readonly IValidationService _validationService;
    private readonly IBookAndGenreRelationService _bookAndGenreRelationService;


    public GenreService(AppDataContext context, IValidationService validationService, IBookAndGenreRelationService bookAndGenreRelationService)
    {
        _context = context;
        _validationService = validationService;
        _bookAndGenreRelationService = bookAndGenreRelationService;
    }

    public string? AddGenre(string genreName)
    {

        if (ValidateOnCreate(genreName) is string error)
            return error;

        var genre = new Genre(genreName);
        _context.Genres.Add(genre);
        _context.Genres.SaveChanges();
        return null;
    }

    public Genre GetGenre(int id)
    {
        var genre = _context.Genres.FirstOrDefault(gen => gen.Id == id);
        if (genre == null)
            throw new InvalidOperationException();

        return genre.Copy();
    }

    public string? Delete(int id)
    {
        if (_bookAndGenreRelationService.GenreHasRelatedBooks(id))
            return "Sorry, you can't delete this genre. Genre has related books in the library!";

        var genreIndex = _context.Genres.FindIndex(genre => genre.Id == id);
        _context.Genres.RemoveAt(genreIndex);
        _context.Genres.SaveChanges();
        return null;
    }

    public string? Update(Genre genre)
    {
        if (ValidateOnUpdate(genre) is string error)
            return error;

        var oldGenre = _context.Genres.FirstOrDefault(gen => gen.Id == genre.Id);

        if (oldGenre == null)
            throw new InvalidOperationException();

        oldGenre.Name = genre.Name;
        _context.Genres.SaveChanges();

        return null;
    }

    public List<Genre> Search(string keyword)
        => _context.Genres
        .Where(genre => genre.Name
            .Contains(keyword, StringComparison.OrdinalIgnoreCase))
        .OrderBy(genre => genre.Name)
        .ToList();
        
    

    public int GetAllGenresCount()
        => _context.Genres.Count;

    public List<Genre> GetAllGenres()
        => _context.Genres.OrderBy(genre => genre.Name).ToList();

    public bool GenreExists(int id)
        => _context.Genres.Any(genre => genre.Id == id);

    private bool GenreExists(string genreName)
        => _context.Genres.Any(g => g.Name.Equals(genreName, StringComparison.OrdinalIgnoreCase));

    private string? ValidateOnCreate(string genreName)
    {
        if (_validationService.CheckGenreName(genreName) is string error)
            return error;
        if (GenreExists(genreName))
            return "Genre already Exists";

        return null;
    }

    private string? ValidateOnUpdate(Genre newGenre)
    {
        if (_validationService.CheckGenreName(newGenre.Name) is string error)
            return error;

        var genre = GetGenre(newGenre.Id);
        if (genre == null)
            throw new ArgumentException();

        if (genre.Name.Equals(newGenre.Name, StringComparison.OrdinalIgnoreCase))
            return null;

        if (GenreExists(newGenre.Name))
            return "Genre already Exists";

        return null;
    }
}