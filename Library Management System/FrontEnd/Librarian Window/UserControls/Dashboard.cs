using BackEnd.Models.Constants;
using BackEnd.Models.Entities;
using BackEnd.Services.Interfaces;

namespace FrontEnd.Librarian_Window.UserControls
{
    public partial class Dashboard : UserControl
    {
        private readonly Form _parent;
        private readonly IAuthorService _authorService;
        private readonly IGenreService _genreService;
        private readonly IBookService _bookService;
        private readonly IUserService _userService;

        public Dashboard(Form parent, IAuthorService authorService, IGenreService genreService,
            IBookService bookService, IUserService userService)
        {
            InitializeComponent();

            _parent = parent;
            _authorService = authorService;
            _genreService = genreService;
            _bookService = bookService;
            _userService = userService;

            InitializePage();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            InitializePage();
        }

        public void InitializePage()
        {
            totalBooks_lbl.Text = _bookService.GetAllBooksCount().ToString();
            totalUniqueBooks_lbl.Text = _bookService.GetUniqueBooksCount().ToString();
            totalAvailableBooks_lbl.Text = _bookService.GetAllAvailableBooksCount().ToString();
            totalBorrowedBooks_lbl.Text = _bookService.GetAllBorrowedBooksCount().ToString();
            totalAuthors_lbl.Text = _authorService.GetAllAuthorsCount().ToString();
            totalGenres_lbl.Text = _genreService.GetAllGenresCount().ToString();
            totalReaders_lbl.Text = _userService.GetAllReadersCount().ToString();

            var genres = _genreService.GetAllGenres();
            InitializeGenrePanel(genres);
            var authors = _authorService.GetAllAuthors();
            InitializeAuthorPanel(authors);
            var books = _bookService.GetAllBooks();
            InitializeBookPanel(books);
        }

        private void addGenre_btn_Click(object sender, EventArgs e)
        {
            var genreAddWindow = new GenreAddWindow(_parent, this, _genreService, null);
            genreAddWindow.Show();
        }

        private void InitializeGenrePanel(List<Genre> genres)
        {
            genrePanel.Controls.Clear();
            foreach (var item in genres)
            {
                var genre = new NameView((item.Name, item.Id, ItemType.Genre), _parent, this);
                genre.genreService = _genreService;
                genrePanel.Controls.Add(genre);
            }
        }

        private void InitializeAuthorPanel(List<Author> authors)
        {
            authorPanel.Controls.Clear();
            foreach (var item in authors)
            {
                var author = new NameView((item.FullName, item.Id, ItemType.Author), _parent, this);
                author.authorService = _authorService;
                authorPanel.Controls.Add(author);
            }
        }

        private void InitializeBookPanel(List<Book> books)
        {
            bookPanel.Controls.Clear();
            foreach (var item in books)
            {
                var bookView = new NameView((item.Title, item.Id, ItemType.Book), _parent, this);
                bookView.bookService = _bookService;
                bookView.authorService = _authorService;
                bookView.genreService = _genreService;
                bookPanel.Controls.Add(bookView);
            }
        }

        private void genreSearch_tb_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(genreSearch_tb.Text))
                InitializeGenrePanel(_genreService.GetAllGenres());
        }

        private void genreSearch_btn_Click(object sender, EventArgs e)
        {
            InitializeGenrePanel(_genreService.Search(genreSearch_tb.Text));
        }

        private void addAuthor_btn_Click(object sender, EventArgs e)
        {
            var authorAddWindow = new AddAuthorWindow(_parent, this, _authorService, null);
            authorAddWindow.Show();
        }

        private void authorSearch_btn_Click(object sender, EventArgs e)
        {
            var authors = _authorService.Search(authorSearch_tb.Text);
            InitializeAuthorPanel(authors);
        }

        private void authorSearch_tb_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(authorSearch_tb.Text))
            {
                var authors = _authorService.GetAllAuthors();
                InitializeAuthorPanel(authors);
            }
        }

        private void addBook_btn_Click(object sender, EventArgs e)
        {
            var bookAddWindow = new AddBookWindow(_parent, this, _bookService, _genreService, _authorService, null);
            bookAddWindow.Show();
        }

        private void bookSearch_btn_Click(object sender, EventArgs e)
        {
            var books = _bookService.SearchByTitle(bookSearch_tb.Text);
            InitializeBookPanel(books);
        }

        private void bookSearch_tb_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(bookSearch_tb.Text))
            {
                var books = _bookService.GetAllBooks();
                InitializeBookPanel(books);
            }
        }
    }
}