using BackEnd.Models.Common;

namespace BackEnd.Models.Entities;

public class Reputation : IEntity, ICopyable<Reputation>
{
    public Reputation(int rating, int userId, int bookId)
    {
        Rating = rating;
        UserId = userId;
        BookId = bookId;
    }

    private Reputation(Reputation reputation)
    {
        Id = reputation.Id;
        Rating = reputation.Rating;
        UserId = reputation.UserId;
        BookId = reputation.BookId;
    }

    public int Id { get; set; }
    public int Rating { get; set; }
    public int UserId { get; set; }
    public int BookId { get; set; }

    public Reputation Copy()
    {
        return new Reputation(this);
    }
}