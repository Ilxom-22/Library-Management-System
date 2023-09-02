using BackEnd.DataLayer.Context;
using BackEnd.Models.Constants;
using BackEnd.Models.Entities;
using BackEnd.Services.Interfaces;

namespace BackEnd.Services.Service;

public class BookService : IBookService
{
    private readonly AppDataContext _context;
    private readonly IAuthorService _authorService;
    private readonly IGenreService _genreService;
    private readonly IBookAndGenreRelationService _bookGenreRelation;
    private readonly IRatingService _ratingService;

    public BookService(AppDataContext context, IAuthorService authorService, IGenreService genreService, 
        IBookAndGenreRelationService bookGenreRelation, IRatingService ratingService)
    {
        _context = context;
        _authorService = authorService;
        _genreService = genreService;
        _bookGenreRelation = bookGenreRelation;
        _ratingService = ratingService;
    }

    public string? AddBook(string title, string description, int authorId, int quantity, List<int> genresId)
    {
        if (ValidateOnCreate(title, description, authorId, quantity, genresId) is string error)
            return error;

        if (BookExists(title, authorId))
            return "Book already exists!";

        var book = new Book(title, description, authorId, quantity);
        _context.Books.Add(book);
        _bookGenreRelation.AddGenreRelations(book.Id, genresId);

        _context.Books.SaveChanges();
       

        return null;
    }

    public string? Update(Book book, List<int> genresId)
    {
        if (ValidateOnUpdate(book, genresId) is string error)
            return error;

        var oldBook = _context.Books.FirstOrDefault(self => self.Id == book.Id);

        if (oldBook == null)
            throw new InvalidOperationException();

        if (!oldBook.Equals(book) && BookExists(book.Title, book.AuthorId))
            return "Could not update!. The same book already exists!";

        oldBook.Title = book.Title;
        oldBook.Description = book.Description;
        oldBook.AuthorId = book.AuthorId;
        oldBook.Quantity = book.Quantity;

        _bookGenreRelation.RemoveGenreRelations(book.Id);
        _bookGenreRelation.AddGenreRelations(book.Id, genresId);
        _context.Books.SaveChanges();

        return null;
    }

    public Book GetBook(int bookId)
    {
        var book = _context.Books.FirstOrDefault(book => book.Id == bookId);
        if (book == null)
            throw new InvalidOperationException();

        return book.Copy();
    }
        
    public List<Genre> GetBookGenres(int bookId)
    {
        var genres = new List<Genre>();
        foreach (var genreId in _bookGenreRelation.GetGenresId(bookId))
            genres.Add(_genreService.GetGenre(genreId));

        return genres;
    }

    public string? Delete(int bookId)
    {
        var book = GetBook(bookId);

        if (book == null)
            throw new InvalidOperationException();
        if (book.Quantity != book.AvailableQuantity)
            return "Sorry, you can't delete this book from library. There are still readers who borrowed the book!";

        _context.Books.Remove(book);
        _ratingService.RemoveRatings(bookId);
        _bookGenreRelation.RemoveGenreRelations(bookId);

        _context.Books.SaveChanges();
        return null;
    }

    public void RateBook(int rating, int userId, int bookId)
    {
        var rate = new Reputation(rating, userId, bookId);
        _ratingService.AddRating(rate);
        var book = _context.Books.First(book => book.Id == bookId);
        book.Rating = _ratingService.RecalculateBookRating(bookId);

        _context.Books.SaveChanges();
    }

    public List<Book> GetAllBooks()
        => _context.Books.OrderBy(book => book.Title).ToList();

    public List<Book> SearchByTitle(string keyword)
        => _context.Books
        .Where(book => book.Title
            .Contains(keyword, StringComparison.OrdinalIgnoreCase))
        .OrderBy(book => book.Title).ToList();

    public List<Book> AdvancedSearch(string keyword)
        => _context.Books
            .Where(book => book.Title
                .Contains(keyword, StringComparison.OrdinalIgnoreCase)
                || GetBookAuthor(book.AuthorId).FullName
                .Contains(keyword, StringComparison.OrdinalIgnoreCase))
            .ToList();

    public List<Book> FilterBook(BookFilterModel model)
    {
        var filterQuery = _context.Books
            .Where(book => (!model.AuthorsId.Any() || model.AuthorsId.Contains(book.AuthorId))
                && (model.Rating is null || book.Rating >= model.Rating)
                && (!model.GenresId.Any() || ContainsGenre(model.GenresId, book.Id)));

        return model.IsDescending
            ? filterQuery
                .OrderByDescending(book => book.Title)
                .ToList()
            : filterQuery
                .OrderBy(book => book.Title)
                .ToList();
    }

    public List<Book> GetBooksByAuthor(int authorId)
        => _context.Books
            .Where(book => book.AuthorId == authorId)
            .ToList();

    public int GetAllBooksCount()
       => _context.Books.Select(book => book.Quantity).Sum();

    public int GetUniqueBooksCount()
       => _context.Books.Count;

    public int GetAllAvailableBooksCount()
        => _context.Books.Select(book => book.AvailableQuantity).Sum();

    public int GetAllBorrowedBooksCount()
        => _context.Books.Select(book => book.Quantity - book.AvailableQuantity).Sum();

    public bool BookExists(int bookId) 
        => _context.Books.Any(book => book.Id == bookId);

    public void CheckIn(Book book)
    {
        var existingBook = _context.Books.FirstOrDefault(@this => @this.Id == book.Id);
        if (existingBook == null)
            throw new InvalidOperationException();

        if (existingBook.Quantity <= existingBook.AvailableQuantity)
            throw new InvalidOperationException();

        existingBook.AvailableQuantity++;
        _context.Books.SaveChanges();
    }

    public bool CheckOut(Book book) 
    {
        var existingBook = _context.Books.FirstOrDefault(@this => @this.Id == book.Id);
        if (existingBook == null)
            throw new InvalidOperationException();

        if (existingBook.AvailableQuantity == 0)
            return false;

        existingBook.AvailableQuantity--;
        _context.Books.SaveChanges();
        return true;
    }

    private bool BookExists(string title, int authorId)
        => _context.Books
                .Any(self => self.Title
                    .Equals(title, StringComparison.OrdinalIgnoreCase)
                            && self.AuthorId == authorId);

    private int FindBook(int bookId)
        => _context.Books.FindIndex(book => book.Id == bookId);

    private Author GetBookAuthor(int authorId)
        => _authorService.GetAuthor(authorId);

    private bool ContainsGenre(List<int> genresId, int bookId)
    {
        var bookGenres = GetBookGenres(bookId);
        var bookGenresId = bookGenres.Select(genre => genre.Id).ToList();
        
        return bookGenresId.Intersect(genresId).Any();
    }

    private string? ValidateOnCreate(string title, string description, int authorId, int quantity, List<int> genresId)
    {
        if (string.IsNullOrWhiteSpace(title))
            return "Title field can't be empty!";
        if (string.IsNullOrWhiteSpace(description))
            return "Description field can't be empty!";
        if (!_authorService.AuthorExists(authorId))
            return "Invalid Author!";
        if (quantity < 1)
            return "Invalid Quantity";

        if (genresId.Count == 0)
            return "Choose a genre, please...";

        foreach (var id in genresId)
            if (!_genreService.GenreExists(id))
                return "Invalid Genre Id";

        return null;
    }

    private string? ValidateOnUpdate(Book book, List<int> genresId)
    {
        if (ValidateOnCreate(book.Title, book.Description, book.AuthorId, book.Quantity, genresId) is string error)
            return error;

        var oldBook = GetBook(book.Id);
        if (oldBook.Quantity - oldBook.AvailableQuantity > book.Quantity)
            return "The new quantity is less than the borrowed quantity of the book!";

        return null;
    }
}