using BackEnd.Models.Entities;
using BackEnd.Services.Interfaces;

namespace FrontEnd.User_Window.UserControls
{
    public partial class BookView : UserControl
    {
        private readonly UserWindow _parentWindow;
        private readonly LibraryBooks? _parentPage;
        private readonly BorrowedBooks? _borrowedBooks;
        private readonly Book _book;
        private readonly IAuthorService _authorService;
        private readonly IBookService _bookService;
        private readonly IBorrowBookService _borrowBookService;
        private readonly bool IsReturnPage;

        public BookView(Book book, IAuthorService authorService, IBookService bookService,
            UserWindow parentWindow, LibraryBooks? parentPage, BorrowedBooks? borrowedBooks, IBorrowBookService borrowBookService, bool isReturnPage)
        {
            InitializeComponent();
            _book = book;
            _authorService = authorService;
            _bookService = bookService;
            _parentWindow = parentWindow;
            _parentPage = parentPage;
            _borrowBookService = borrowBookService;
            IsReturnPage = isReturnPage;
            _borrowedBooks = borrowedBooks;
        }

        private void BookView_Load(object sender, EventArgs e)
        {
            title_lbl.Text = _book.Title;
            author_lbl.Text = GetAuthor()?.FullName;
            rating_lbl.Text = $"{_book.Rating}/5";
            genre_lbl.Text = "";

            foreach (var item in GetGenres())
                genre_lbl.Text += item.Name + ", ";

            genre_lbl.Text = genre_lbl.Text.TrimEnd(' ', ',');
            if (!IsReturnPage)
            {
                available_lbl.Text = _book.AvailableQuantity > 0 ? "Available" : "Not Available";
            }
            else
            {
                borrow_btn.Text = "Return";
                available_lbl.Text = string.Empty;
            }
        }

        private List<Genre> GetGenres()
            => _bookService.GetBookGenres(_book.Id);

        private Author GetAuthor()
            => _authorService.GetAuthor(_book.AuthorId);

        private void borrow_btn_Click(object sender, EventArgs e)
        {
            if (!IsReturnPage)
            {
                var bookInfo = new BookInfoView(_parentWindow, _parentPage, _book, _bookService, _authorService, this, _borrowBookService);
            }
            else
            {
                var result = MessageBox.Show($"Are you sure you want to return \"{_book.Title}\"?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    _borrowBookService.Return(_parentWindow._user, _book);
                    _borrowedBooks.InitializePage();
                }
            }

        }
    }
}