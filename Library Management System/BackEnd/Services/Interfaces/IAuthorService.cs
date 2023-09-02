using BackEnd.Models.Entities;

namespace BackEnd.Services.Interfaces;

public interface IAuthorService
{
    string? AddAuthor(string name, string lastName, string biography, DateTime dateOfBirth, DateTime? dateOfDeath);
    string? Update(Author author);
    Author GetAuthor(int id);
    string? Delete(int id);
    List<Author> GetAllAuthors();
    List<Author> Search(string keyword);
    int GetAllAuthorsCount();
    bool AuthorExists(int id);
}