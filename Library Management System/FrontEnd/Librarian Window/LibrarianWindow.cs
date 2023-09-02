using BackEnd.Models.Entities;
using BackEnd.Services.Interfaces;
using FrontEnd.Librarian_Window.UserControls;

namespace FrontEnd.Librarian_Page
{
    public partial class LibrarianWindow : Form
    {
        private readonly AuthorizationWindow _parentWindow;
        private readonly User _user;
        private readonly UserCredentials _userCredentials;
        private readonly Dashboard _dashboard;
        private readonly UserActions _userActions;

        public LibrarianWindow(AuthorizationWindow parentWindow, User user,
            UserCredentials userCredentials, IAuthorService authorService,
            IGenreService genreService, IBookService bookService, IUserService userService, 
            IBorrowBookService borrowBookService, IUserCredentialsService userCredentialsService)
        {
            InitializeComponent();
            _parentWindow = parentWindow;
            _user = user;
            _userCredentials = userCredentials;

            _dashboard = new Dashboard(this, authorService, genreService, bookService, userService);
            _userActions = new UserActions(this, borrowBookService, bookService, authorService, userCredentialsService);
        }

        private void LibrarianWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            _parentWindow.Close();
        }

        private void LibrarianWindow_Load(object sender, EventArgs e)
        {
            mainPanel.Controls.Add(_dashboard);
            mainPanel.Controls.Add(_userActions);
            _dashboard.BringToFront();
        }

        private void logout_btn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void books_btn_Click(object sender, EventArgs e)
        {
            _userActions.InitializePage();
            _userActions.BringToFront();
        }

        private void dashboard_btn_Click(object sender, EventArgs e)
        {
            _dashboard.InitializePage();
            _dashboard.BringToFront();
        }
    }
}
