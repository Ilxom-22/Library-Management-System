namespace BackEnd.Models.Constants;

public class BookFilterModel
{
    public BookFilterModel(List<int> authorsId, List<int> genresId, int? rating, bool isDescending)
    {
        AuthorsId = authorsId;
        GenresId = genresId;
        Rating = rating;
        IsDescending = isDescending;
    }

    public List<int> AuthorsId { get; set; }
    public List<int> GenresId { get; set; }
    public int? Rating { get; set; }
    public bool IsDescending { get; set; }
}