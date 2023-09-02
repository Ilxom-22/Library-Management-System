using BackEnd.DataLayer.Context;
using BackEnd.Models.Constants;
using BackEnd.Models.Entities;
using BackEnd.Services.Interfaces;

namespace BackEnd.Services.Service;

public class BorrowBookService : IBorrowBookService
{
    private readonly AppDataContext _context;
    private readonly IBookService _bookService;
    private readonly IUserService _userService;
    private readonly IUserCredentialsService _userCredentialsService;

    public BorrowBookService(AppDataContext context, IBookService bookService, 
        IUserService userService, IUserCredentialsService userCredentials)
    {
        _context = context;
        _bookService = bookService;
        _userService = userService;
        _userCredentialsService = userCredentials;
    }

    public string? Borrow(User user, Book book)
    {
        Validate(user.Id, book.Id);

        if (IsBorrowingLimitReached(user.Id))
            return "Sorry, you can't borrow the book due to your borrowing limit! " +
                "Please return borrowed books and try again!";

        if (IsAlreadyBorrowed(user.Id, book.Id))
            return "You already borrowed this book!";

        if (!_bookService.CheckOut(book))
            return "Sorry, this book is not available right now! Please wait until it is available again!";

        var newHistory = new BorrowHistory(user.Id, book.Id);
        _context.BorrowHistory.Add(newHistory);
        _context.BorrowHistory.SaveChanges();
        return null;
    }

    public void Return(User user, Book book)
    {
        Validate(user.Id, book.Id);

        var borrowHistory = GetHistory(user.Id, book.Id);
        if (borrowHistory == null)
            throw new InvalidOperationException();

        _bookService.CheckIn(book);
        borrowHistory.ReturnedDate = DateTime.Now;
        _context.BorrowHistory.SaveChanges();
    }

    public List<Book> GetBorrowedBooks(int userId)
        => _context.BorrowHistory
            .Where(history => 
                history.UserId == userId 
                && history.ReturnedDate is null)
            .Select(history => _bookService.GetBook(history.BookId))
            .ToList();

    public List<HistoryEvent> GetBorrowHistoryForLastFiveDays()
        => GetLastFiveDaysHistory()
            .Select(history =>
                new HistoryEvent(
                    _bookService.GetBook(history.BookId),
                    _bookService.GetBookGenres(history.BookId),
                    history.BorrowedDate,
                    _userCredentialsService.GetUsernameOfUser(history.UserId),
                    EventType.Borrow))
            .Concat(GetReturnHistory()
                .Select(history => 
                    new HistoryEvent(
                        _bookService.GetBook(history.BookId),
                        _bookService.GetBookGenres(history.BookId),
                        (DateTime)history.ReturnedDate,
                        _userCredentialsService.GetUsernameOfUser(history.UserId),
                        EventType.Return)))
            .OrderByDescending(@event => @event.EventDate)
            .ToList();    

    public bool IsAlreadyBorrowed(int userId, int bookId)
        => _context.BorrowHistory
            .Any(history =>
                history.UserId == userId
                && history.BookId == bookId
                && history.ReturnedDate is null);


    private IQueryable<BorrowHistory> GetLastFiveDaysHistory()
        => _context.BorrowHistory.Where(history =>
            history.BorrowedDate >= DateTime.Now.AddDays(-5)
            && (history.ReturnedDate is null
            || history.ReturnedDate >= DateTime.Now.AddDays(-5)))
            .AsQueryable();

    private List<BorrowHistory> GetReturnHistory()
        => _context.BorrowHistory
            .Where(history => history.ReturnedDate is not null)
            .ToList(); 

    private bool IsBorrowingLimitReached(int userId)
       => _context.BorrowHistory
            .Where(history =>
                history.UserId == userId
                && history.ReturnedDate is null)
            .Count() > 5;

    private BorrowHistory? GetHistory(int userId, int bookId)
        => _context.BorrowHistory
            .FirstOrDefault(history => 
                history.UserId == userId 
                && history.BookId == bookId 
                && history.ReturnedDate is null);

    private void Validate(int userId, int bookId)
    {
        if (!_bookService.BookExists(bookId))
            throw new InvalidOperationException();

        if (!_userService.UserExists(userId))
            throw new InvalidOperationException();
    }
}