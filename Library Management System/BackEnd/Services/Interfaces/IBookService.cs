using BackEnd.Models.Constants;
using BackEnd.Models.Entities;

namespace BackEnd.Services.Interfaces;

public interface IBookService
{
    string? AddBook(string title, string description, int authorId, int quantity, List<int> genresId);
    Book GetBook(int bookId);
    string? Update(Book book, List<int> genresId);
    string? Delete(int bookId);
    void RateBook(int rating, int userId, int bookId);
    List<Genre> GetBookGenres(int bookId);
    List<Book> GetAllBooks();
    List<Book> SearchByTitle(string keyword);
    List<Book> AdvancedSearch(string keyword);
    List<Book> FilterBook(BookFilterModel model);
    List<Book> GetBooksByAuthor(int authorId);
    int GetAllBooksCount();
    int GetUniqueBooksCount();
    int GetAllAvailableBooksCount();
    int GetAllBorrowedBooksCount();
    bool BookExists(int bookId);
    void CheckIn(Book book);
    bool CheckOut(Book book);
}