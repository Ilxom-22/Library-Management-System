using BackEnd.Models.Entities;

namespace BackEnd.Services.Interfaces;

public interface IRatingService
{
    void AddRating(Reputation rating);
    double RecalculateBookRating(int bookId);
    void RemoveRatings(int bookId);
}