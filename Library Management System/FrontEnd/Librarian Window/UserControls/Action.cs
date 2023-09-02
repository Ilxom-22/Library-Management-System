using BackEnd.Models.Constants;
using BackEnd.Models.Entities;
using BackEnd.Services.Interfaces;


namespace FrontEnd.Librarian_Window.UserControls
{
    public partial class Action : UserControl
    {
        private readonly HistoryEvent _history;
        private readonly IBookService _bookService;
        private readonly IAuthorService _authorService;

        public Action(HistoryEvent history, IBookService bookService, IAuthorService authorService, 
            IUserCredentialsService userCredentialsService)
        {
            InitializeComponent();
            _history = history;
            _bookService = bookService;
            _authorService = authorService;

            InitializeControl();
        }

        private void InitializeControl()
        {
            title_lbl.Text = _history.Book.Title;
            author_lbl.Text = _authorService.GetAuthor(_history.Book.AuthorId).FullName;
            genre_lbl.Text = string.Join(", ", _history.GenreList);
            date_lbl.Text = _history.EventDate.ToString("g");
            username_lbl.Text = _history.UserName;
            action_lbl.Text = _history.EventType.ToString();
        }
    }
}
