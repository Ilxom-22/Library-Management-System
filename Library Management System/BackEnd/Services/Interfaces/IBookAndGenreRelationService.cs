namespace BackEnd.Services.Interfaces;

public interface IBookAndGenreRelationService
{
    void AddGenreRelations(int bookId, List<int> genresId);
    void RemoveGenreRelations(int bookId);
    List<int> GetGenresId(int bookId);
    bool GenreHasRelatedBooks(int genreId);
}