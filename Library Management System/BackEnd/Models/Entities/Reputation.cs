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

    public override int GetHashCode()
    {
        int hash = 17;
        hash = hash * 23 + UserId.GetHashCode();
        hash = hash * 23 + BookId.GetHashCode();
        return hash;
    }

    public override bool Equals(object? obj)
    {
        if (obj != null && obj is Reputation)
            return GetHashCode() == obj.GetHashCode();

        return false;
    }
}