using BackEnd.Models.Entities;
using BackEnd.Services.Interfaces;

namespace FrontEnd.User_Window.UserControls
{
    public partial class BorrowedBooks : UserControl
    {
        private readonly User _user;
        private readonly UserWindow _parentWindow;
        private readonly IBorrowBookService _borrowBookService;
        private readonly IAuthorService _authorService;
        private readonly IBookService _bookService;

        public BorrowedBooks(User user, IBorrowBookService borrowBookService, IAuthorService authorService,
            IBookService bookService, UserWindow parentWindow)
        {
            InitializeComponent();
            _user = user;
            _borrowBookService = borrowBookService;
            _authorService = authorService;
            _bookService = bookService;
            _parentWindow = parentWindow;
        }

        private void BorrowedBooks_Load(object sender, EventArgs e)
        {
            InitializePage();
        }

        public void InitializePage()
        {
            var books = _borrowBookService.GetBorrowedBooks(_user.Id);
            if (!books.Any())
            {
                booksPanel.Controls.Clear();
                var label = new Label();
                label.Text = "No Borrowed Books Yet!";
                label.Font = new Font("Segoe UI", 20);
                label.AutoSize = true;
                booksPanel.Controls.Add(label);
                return;
            }

            FillBooksPanel(books);
        }

        private void FillBooksPanel(List<Book> books)
        {
            booksPanel.Controls.Clear();
            foreach (var book in books)
            {
                var bookView = new BookView(book, _authorService, _bookService, _parentWindow, null, this, _borrowBookService, true);
                booksPanel.Controls.Add(bookView);
            }
        }
    }
}
