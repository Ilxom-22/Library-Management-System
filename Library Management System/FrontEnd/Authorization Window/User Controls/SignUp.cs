using BackEnd.Services.Interfaces;
using FrontEnd.User_Window;

namespace FrontEnd.Authorization_Page
{
    public partial class SignUp : UserControl
    {
        private readonly AuthorizationWindow _parentWindow;
        private readonly IRegistrationService _registrationService;
        private readonly IUserService _userService;
        private readonly IBookService _bookService;
        private readonly IGenreService _genreService;
        private readonly IAuthorService _authorService;
        private readonly IBorrowBookService _borrowBookService;

        public SignUp(AuthorizationWindow parentPage, IRegistrationService registrationService, IUserService userService, IBookService bookService, IGenreService genreService, IAuthorService authorService, IBorrowBookService borrowBookService)
        {
            InitializeComponent();
            _parentWindow = parentPage;
            _registrationService = registrationService;
            _userService = userService;
            _bookService = bookService;
            _genreService = genreService;
            _authorService = authorService;
            _borrowBookService = borrowBookService;
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            firstName_tb.Clear();
            lastName_tb.Clear();
            email_tb.Clear();
            username_tb.Clear();
            password_tb.Clear();

            _parentWindow.WelcomePage.BringToFront();
        }

        private void signUp_btn_Click(object sender, EventArgs e)
        {
            var user = _registrationService
                .RegisterUser(firstName_tb.Text, lastName_tb.Text, 
                email_tb.Text, username_tb.Text, password_tb.Text, 
                BackEnd.Models.Constants.RoleOfUser.Reader, out string errorMessage);

            if (user == null)
            {
                MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var userWindow = new UserWindow(_parentWindow, user.Value.UserInfo, user.Value.UserCredentials, _userService, 
                _genreService, _authorService, _bookService, _borrowBookService);
            userWindow.Show();
            _parentWindow.Hide();
        }
    }
}
