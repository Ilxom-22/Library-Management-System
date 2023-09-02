using BackEnd.Models.Constants;
using BackEnd.Services.Interfaces;
using FrontEnd.Librarian_Page;
using FrontEnd.User_Window;

namespace FrontEnd.Authorization_Page.User_Controls
{
    public partial class SignIn : UserControl
    {
        private readonly AuthorizationWindow _parentWindow;
        private readonly IRegistrationService _registrationService;
        private readonly IAuthorService _authorService;
        private readonly IGenreService _genreService;
        private readonly IBookService _bookService;
        private readonly IUserService _userService;
        private readonly IBorrowBookService _borrowBookService;
        private readonly IUserCredentialsService _userCredentialsService;

        public SignIn(AuthorizationWindow parentWindow, IRegistrationService registrationService,
            IAuthorService authorService, IGenreService genreService, IBookService bookService, 
            IUserService userService, IBorrowBookService borrowBookService, IUserCredentialsService userCredentialsService)
        {
            InitializeComponent();
            _parentWindow = parentWindow;
            _registrationService = registrationService;
            _authorService = authorService;
            _genreService = genreService;
            _bookService = bookService;
            _userService = userService;
            _borrowBookService = borrowBookService;
            _userCredentialsService = userCredentialsService;
        }

        private void signIn_btn_Click(object sender, EventArgs e)
        {
            var user = _registrationService.SignIn(username_tb.Text, password_tb.Text);
            if (user == null)
            {
                MessageBox.Show("Username or Password is incorrect!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var userInfo = user.Value.UserInfo;
            var userCredentials = user.Value.UserCredentials;

            if (userInfo.UserRole == RoleOfUser.Librarian)
            {
                var librarianWindow = new LibrarianWindow(_parentWindow, userInfo, userCredentials, 
                     _authorService, _genreService, _bookService, _userService, _borrowBookService, _userCredentialsService);
                librarianWindow.Show();
                _parentWindow.Hide();
                return;
            }

            var userWindow = new UserWindow(_parentWindow, userInfo, userCredentials, _userService, _genreService, _authorService, _bookService, _borrowBookService);
            userWindow.Show();

            _parentWindow.Hide();
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            username_tb.Clear();
            password_tb.Clear();

            _parentWindow.WelcomePage.BringToFront();
        }
    }
}