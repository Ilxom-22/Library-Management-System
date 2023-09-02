using BackEnd.Services.Interfaces;
using FrontEnd.Authorization_Page;
using FrontEnd.Authorization_Page.User_Controls;

namespace FrontEnd
{
    public partial class AuthorizationWindow : Form
    {
        public readonly WelcomePage WelcomePage;
        public readonly SignUp SignUpPage;
        public readonly SignIn SignInPage;
        public readonly IRegistrationService RegistrationService;

        public AuthorizationWindow(IRegistrationService registrationService, 
            IAuthorService authorService, IGenreService genreService, 
            IBookService bookService, IUserService userService, IBorrowBookService borrowBookService, 
            IUserCredentialsService userCredentialsService)
        {
            InitializeComponent();
            RegistrationService = registrationService;

            WelcomePage = new WelcomePage(this);
            SignUpPage = new SignUp(this, RegistrationService, userService, bookService, genreService, authorService, borrowBookService);
            SignInPage = new SignIn(this, RegistrationService, authorService, genreService, bookService, userService, borrowBookService, userCredentialsService);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            mainPanel.Controls.Add(WelcomePage);
            mainPanel.Controls.Add(SignUpPage);
            mainPanel.Controls.Add(SignInPage);

            WelcomePage.BringToFront();
        }
    }
}