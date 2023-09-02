using BackEnd.Models.Constants;
using BackEnd.Services.Interfaces;

namespace FrontEnd.Librarian_Window.UserControls
{
    public partial class NameView : UserControl
    {
        private readonly Form _parentWindow;
        private readonly Dashboard _parentPage;
        private readonly (string name, int id, ItemType type) _item;

        public IGenreService? genreService;
        public IAuthorService? authorService;
        public IBookService? bookService;


        public NameView((string name, int id, ItemType type) item, Form parentWindow, Dashboard parentPage)
        {
            InitializeComponent();
            _item = item;
            _parentWindow = parentWindow;
            _parentPage = parentPage;
            Initialize();
        }

        private void edit_btn_Click(object sender, EventArgs e)
        {
            if (_item.type == ItemType.Genre)
            {
                var updateWindow = new GenreAddWindow(_parentWindow, _parentPage, genreService, _item.id);
                updateWindow.Show();
            }
            else if ( _item.type == ItemType.Author)
            {
                var updateWindow = new AddAuthorWindow(_parentWindow, _parentPage, authorService, _item.id);
                updateWindow.Show();
            }
            else if (_item.type == ItemType.Book)
            {
                var updateWindow = new AddBookWindow(_parentWindow, _parentPage, bookService, genreService, authorService, _item.id);
                updateWindow.Show();
            }
        }

        private void Initialize()
        {
            name_lbl.Text = _item.name;
        }
    }
}
