using BackEnd.Models.Entities;

namespace BackEnd.Models.Constants;

public class HistoryEvent
{
    public HistoryEvent(Book book, List<Genre> genres, DateTime eventDate, string username, EventType eventType)
    {
        Book = book;
        GenreList = genres;
        EventDate = eventDate;
        UserName = username;
        EventType = eventType;
    }

    public Book Book { get; set; }
    public List<Genre> GenreList { get; set; }
    public DateTime EventDate { get; set; }
    public string UserName { get; set; }
    public EventType EventType { get; set; }
}