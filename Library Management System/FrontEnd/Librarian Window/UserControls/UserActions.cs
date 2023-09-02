using BackEnd.Services.Interfaces;
using FrontEnd.Librarian_Page;

namespace FrontEnd.Librarian_Window.UserControls
{
    public partial class UserActions : UserControl
    {
        private readonly IBorrowBookService _borrowBookService;
        private readonly IBookService _bookService;
        private readonly IAuthorService _authorService;
        private readonly IUserCredentialsService _userCredentialsService;
        private readonly LibrarianWindow _parentWindow;

        public UserActions(LibrarianWindow parentWindow, IBorrowBookService borrowBookService, IBookService bookService, 
            IAuthorService authorService, IUserCredentialsService userCredentialsService)
        {
            InitializeComponent();
            _parentWindow = parentWindow;
            _borrowBookService = borrowBookService;
            _bookService = bookService;
            _authorService = authorService;
            _userCredentialsService = userCredentialsService;
        }

        private void UserActions_Load(object sender, EventArgs e)
        {
            InitializePage();
        }

        public void InitializePage()
        {
            var history = _borrowBookService.GetBorrowHistoryForLastFiveDays();
            historyPanel.Controls.Clear();
            foreach (var item in history)
            {
                var action = new Action(item, _bookService, _authorService, _userCredentialsService);
                historyPanel.Controls.Add(action);
            }
        }
    }
}
