using BackEnd.Models.Entities;
using BackEnd.DataLayer.FileSet;

namespace BackEnd.DataLayer.Context;

public class AppDataContext
{
    public FileSet<Book> Books { get; init; } = new FileSet<Book>(nameof(Books));
    public FileSet<Author> Authors { get; init; } = new FileSet<Author>(nameof(Authors));
    public FileSet<Genre> Genres { get; init; } = new FileSet<Genre>(nameof(Genres));
    public FileSet<Reputation> Reputations { get; init; } = new FileSet<Reputation>(nameof(Reputations));
    public FileSet<User> Users { get; init; } = new FileSet<User>(nameof(Users));
    public FileSet<UserCredentials> UserCredentials { get; init; } = new FileSet<UserCredentials>(nameof(UserCredentials));
    public FileSet<BookAndGenre> BookAndGenres { get; init; } = new FileSet<BookAndGenre>(nameof(BookAndGenres));
    public FileSet<BorrowHistory> BorrowHistory { get; init; } = new FileSet<BorrowHistory>(nameof(BorrowHistory));


    public AppDataContext()
    {
        Initialize();
    }

    public void SaveChanges()
    {
        Books.SaveChanges();
        Authors.SaveChanges();
        Genres.SaveChanges();
        Reputations.SaveChanges();
        Users.SaveChanges();
        UserCredentials.SaveChanges();
        BookAndGenres.SaveChanges();
        BorrowHistory.SaveChanges();
    }

    private void Initialize()
    {
        Books.Initialize();
        Authors.Initialize();
        Genres.Initialize();
        Reputations.Initialize();
        Users.Initialize();
        UserCredentials.Initialize();
        BookAndGenres.Initialize();
        BorrowHistory.Initialize();
    }
}