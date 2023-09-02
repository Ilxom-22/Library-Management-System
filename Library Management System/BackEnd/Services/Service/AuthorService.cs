using BackEnd.DataLayer.Context;
using BackEnd.Models.Entities;
using BackEnd.Services.Interfaces;

namespace BackEnd.Services.Service;

public class AuthorService : IAuthorService
{
    private readonly AppDataContext _context;
    private readonly IValidationService _validationService;

    public AuthorService(AppDataContext context, IValidationService validationService)
    {
        _context = context;
        _validationService = validationService;

    }

    public string? AddAuthor(string name, string lastName, string biography, DateTime dateOfBirth, DateTime? dateOfDeath)
    {
        if (ValidateAuthor(ref name, ref lastName, biography, dateOfBirth, dateOfDeath) is string error)
            return error;

        var author = new Author(name, lastName, biography, dateOfBirth, dateOfDeath);
        if (AuthorExists(author))
            return "Author already exists!";

        _context.Authors.Add(author);
        _context.Authors.SaveChanges();

        return null;

    }

    public string? Delete(int id)
    {
        if (AuthorHasBooks(id))
            return "Sorry, you can't delete this author. Author has active books in the library!";

        var authorIndex = _context.Authors.FindIndex(author => author.Id == id);
        _context.Authors.RemoveAt(authorIndex);
        _context.Authors.SaveChanges();
        return null;
    }

    public Author GetAuthor(int id)
    {
        var author = _context.Authors
                .FirstOrDefault(author => author.Id == id);

        if (author == null)
            throw new InvalidOperationException();

        return author.Copy();
    }

    public string? Update(Author author)
    {
        if (ValidateOnUpdate(author) is string error)
            return error;

        var oldAuthor = _context.Authors.FirstOrDefault(oldAuthor => oldAuthor.Id == author.Id);
        if (oldAuthor == null)
            throw new InvalidOperationException();

        if (!oldAuthor.Equals(author) && AuthorExists(author))
            return "Could not update! The same author already exists!";

       

        oldAuthor.Name = author.Name;
        oldAuthor.LastName = author.LastName;
        oldAuthor.Biography = author.Biography;
        oldAuthor.DateOfBirth = author.DateOfBirth;
        oldAuthor.DateOfDeath = author.DateOfDeath;

        _context.Authors.SaveChanges();

        return null;
    }

    public List<Author> GetAllAuthors()
        => _context.Authors.OrderBy(author => author.FullName).ToList();

    public List<Author> Search(string keyword)
        => _context.Authors
        .Where(author => author.FullName
               .Contains(keyword, StringComparison.OrdinalIgnoreCase))
        .OrderBy(author => author.FullName)
        .ToList();

    public int GetAllAuthorsCount()
      => _context.Authors.Count;

    public bool AuthorExists(int id)
        => _context.Authors.Any(author => author.Id == id);

    private bool AuthorExists(Author author)
        => _context.Authors.Any(self => self.Equals(author));

    private bool AuthorHasBooks(int authorId)
     => _context.Books.Any(book => book.AuthorId == authorId);

    private string? ValidateAuthor(ref string name, ref string lastName, string biography, DateTime dateOfBirth, DateTime? dateOfDeath)
    {
        if (!_validationService.CheckName(ref name))
            return "Input valid Name, please...";
        if (!_validationService.CheckLastName(ref lastName))
            return "Input valid Last Name, please...";
        if (string.IsNullOrWhiteSpace(biography))
            return "Biography field can't be empty!";
        if (dateOfBirth >= DateTime.Now.AddYears(-15))
            return "Input valid date of birth, please...";
        if (dateOfDeath != null && dateOfDeath > DateTime.Now || dateOfDeath <= dateOfBirth)
            return "Input valid date of death, please...";

        return null;
    }

    private string? ValidateOnUpdate(Author author)
    {
        var name = author.Name;
        var lastName = author.LastName;

        if (ValidateAuthor(ref name, ref lastName, author.Biography, author.DateOfBirth, author.DateOfDeath) is string error)
            return error;

        author.Name = name;
        author.LastName = lastName;
        return null;
    }
}