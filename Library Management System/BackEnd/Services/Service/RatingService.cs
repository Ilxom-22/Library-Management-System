using BackEnd.DataLayer.Context;
using BackEnd.Models.Entities;
using BackEnd.Services.Interfaces;

namespace BackEnd.Services.Service;

public class RatingService : IRatingService
{
    private readonly AppDataContext _context;

    public RatingService(AppDataContext context)
    {
        _context = context;
    }

    public void AddRating(Reputation rating)
    {
        var oldRating = RatingExists(rating);

        if (oldRating != null)
            oldRating.Rating = rating.Rating;
        else
            _context.Reputations.Add(rating);

        _context.SaveChanges();
    }

    public double RecalculateBookRating(int bookId)
        => Math.Round(_context.Reputations
            .Where(rate => rate.BookId == bookId)
            .Select(rate => rate.Rating)
            .Average(), 1);

    public void RemoveRatings(int bookId)
    {
        foreach (var rating in FindRatings(bookId))
            _context.Reputations.Remove(rating);

        _context.Reputations.SaveChanges();
    }

    private Reputation? RatingExists(Reputation rating)
        => _context.Reputations
            .FirstOrDefault(reputation =>
                reputation.UserId == rating.UserId 
                && reputation.BookId == rating.BookId);

    private List<Reputation> FindRatings(int bookId)
        => _context.Reputations
            .Where(rating =>  rating.BookId == bookId)
            .ToList();
}