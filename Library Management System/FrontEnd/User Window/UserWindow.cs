using BackEnd.Models.Entities;
using BackEnd.Services.Interfaces;
using FrontEnd.User_Window.UserControls;

namespace FrontEnd.User_Window
{
    public partial class UserWindow : Form
    {
        private readonly AuthorizationWindow _parentWindow;
        public readonly User _user;
        private readonly UserCredentials _userCredentials;
        private readonly IGenreService _genreService;
        private readonly IAuthorService _authorService;
        private readonly IBookService _bookService;
        private readonly IUserService _userService;


        private readonly LibraryBooks _libraryBooks;
        private readonly BorrowedBooks _borrowedBooks;

        public UserWindow(AuthorizationWindow parentWindow, User user, UserCredentials userCredentials,
            IUserService userService, IGenreService genreService, IAuthorService authorService, IBookService bookService, IBorrowBookService borrowBookService)
        {
            InitializeComponent();
            _parentWindow = parentWindow;
            _user = user;
            _userCredentials = userCredentials;
            _userService = userService;
            _genreService = genreService;
            _authorService = authorService;
            _bookService = bookService;

            _libraryBooks = new LibraryBooks(bookService, genreService, authorService, this, borrowBookService);
            _borrowedBooks = new BorrowedBooks(user, borrowBookService, authorService, _bookService, this);
        }

        private void UserWindow_Load(object sender, EventArgs e)
        {
            mainPanel.Controls.Add(_libraryBooks);
            mainPanel.Controls.Add(_borrowedBooks);
            _libraryBooks.BringToFront();
        }

        private void UserWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            _parentWindow.Close();
        }

        private void logout_btn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void books_btn_Click(object sender, EventArgs e)
        {
            _libraryBooks.InitializePage();
            _libraryBooks.BringToFront();
        }

        private void borrowedBooks_btn_Click(object sender, EventArgs e)
        {
            _borrowedBooks.InitializePage();
            _borrowedBooks.BringToFront();
        }
    }
}
