using BackEnd.Services.Interfaces;

namespace FrontEnd.Authorization_Page
{
    public partial class WelcomePage : UserControl
    {
        private readonly AuthorizationWindow _parentWindow;

        public WelcomePage(AuthorizationWindow parentWindow)
        {
            InitializeComponent();
            _parentWindow = parentWindow;
        }

        private void signUp_btn_Click(object sender, EventArgs e)
        {
            _parentWindow.SignUpPage.BringToFront();
        }

        private void signIn_btn_Click(object sender, EventArgs e)
        {
            _parentWindow.SignInPage.BringToFront();
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            _parentWindow.Close();
        }
    }
}
