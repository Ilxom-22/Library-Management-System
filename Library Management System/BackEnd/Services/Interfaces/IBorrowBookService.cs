using BackEnd.Models.Constants;
using BackEnd.Models.Entities;

namespace BackEnd.Services.Interfaces;

public interface IBorrowBookService
{
    string? Borrow(User user, Book book);
    void Return(User user, Book book);
    List<Book> GetBorrowedBooks(int userId);
    List<HistoryEvent> GetBorrowHistoryForLastFiveDays();
}