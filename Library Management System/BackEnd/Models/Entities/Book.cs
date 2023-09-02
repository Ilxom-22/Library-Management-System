using BackEnd.Models.Common;

namespace BackEnd.Models.Entities;

public class Book : IEntity, ICopyable<Book>
{
    public Book(string title, string description, int authorId, int quantity)
    {
        Title = title;
        Description = description;
        AuthorId = authorId;
        Quantity = quantity;
        AvailableQuantity = quantity;
        Rating = 0;
    }

    private Book(Book book)
    {
        Id = book.Id;
        Title = book.Title;
        Description = book.Description;
        AuthorId = book.AuthorId;
        Quantity = book.Quantity;
        AvailableQuantity = book.AvailableQuantity;
        Rating = book.Rating;
    }

    public int Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public int AuthorId { get; set; }
    public int Quantity { get; set; }
    public int AvailableQuantity { get; set; }
    public double Rating { get; set; }

    public Book Copy()
    {
        return new Book(this);
    }

    public override int GetHashCode()
    {
        int hash = 17;
        hash = hash * 23 + Title.GetHashCode();
        hash = hash * 23 + AuthorId.GetHashCode();
        return hash;
    }

    public override bool Equals(object? obj)
    {
        if (obj != null && obj is Book)
            return GetHashCode() == obj.GetHashCode();

        return false;
    }
}