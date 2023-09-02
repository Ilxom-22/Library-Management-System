using BackEnd.Models.Entities;

namespace BackEnd.Services.Interfaces;

public interface IGenreService
{
    string? AddGenre(string genreName);
    Genre GetGenre(int id);
    string? Update(Genre genre);
    List<Genre> Search(string keyword);
    string? Delete(int id);
    int GetAllGenresCount();
    List<Genre> GetAllGenres();
    bool GenreExists(int id);
}