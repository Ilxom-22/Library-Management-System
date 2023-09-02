using BackEnd.Models.Common;

namespace BackEnd.Models.Entities;

public class BorrowHistory : IEntity
{
    public BorrowHistory(int userId, int bookId)
    {
        UserId = userId;
        BookId = bookId;
        BorrowedDate = DateTime.Now;
    }

    public int Id { get; set; }
    public int UserId { get; set; }
    public int BookId { get; set; }
    public DateTime BorrowedDate { get; set; }
    public DateTime? ReturnedDate { get; set; }
}