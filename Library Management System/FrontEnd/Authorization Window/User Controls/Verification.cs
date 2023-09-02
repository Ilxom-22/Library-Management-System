using BackEnd.Services.Interfaces;

namespace FrontEnd.Authorization_Page
{
    public partial class Verification : UserControl
    {
        private readonly AuthorizationWindow _parentWindow;
        private readonly IRegistrationService _registrationService;
        private string? verificationPassword;

        public Verification(AuthorizationWindow parentWindow, IRegistrationService registration)
        {
            InitializeComponent();
            _parentWindow = parentWindow;
            _registrationService = registration;
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            maskedCode_tb.Clear();
            _parentWindow.SignUpPage.BringToFront();
        }

        private void Verification_Load(object sender, EventArgs e)
        {
        }
    }
}
