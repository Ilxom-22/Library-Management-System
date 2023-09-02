using BackEnd.Models.Entities;
using BackEnd.Services.Interfaces;

namespace FrontEnd.User_Window.UserControls
{
    public partial class BookInfoView : UserControl
    {
        private readonly UserWindow _parentWindow;
        private readonly LibraryBooks _parentPage;
        private readonly BookView _parentControl;
        private readonly IBookService _bookService;
        private readonly IAuthorService _authorService;
        private readonly IBorrowBookService _borrowBookService;
        private readonly Book _book;

        public BookInfoView(UserWindow parentWindow, LibraryBooks parentPage, Book book,
            IBookService bookService, IAuthorService authorService, BookView parentControl,
            IBorrowBookService borrowBookService)
        {
            InitializeComponent();

            _parentWindow = parentWindow;
            _parentPage = parentPage;
            _book = book;
            _bookService = bookService;
            _authorService = authorService;
            _parentControl = parentControl;

            InitializePage();
            _borrowBookService = borrowBookService;
        }

        private void InitializePage()
        {
            var author = _authorService.GetAuthor(_book.AuthorId);
            bookName_lbl.Text = _book.Title;
            bookDescription_rtb.Text = _book.Description;
            authorName_lbl.Text = author.FullName;
            authorBiography_rtb.Text = author.Biography;
            totalQuantity_lbl.Text = _book.Quantity.ToString();
            availableQuantity_lbl.Text = _book.AvailableQuantity.ToString();
            borrowed_lbl.Text = (_book.Quantity - _book.AvailableQuantity).ToString();
            rating_lbl.Text = _book.Rating.ToString() + "/5";

            var books = _bookService.GetBooksByAuthor(_book.AuthorId);
            foreach (var book in books)
                dataGridView1.Rows.Add(book.Title, string.Join(", ", _bookService.GetBookGenres(book.Id)), book.Rating);



            _parentWindow.mainPanel.Controls.Add(this);
            BringToFront();
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            _parentWindow.Controls.Remove(this);
            _parentPage.BringToFront();
        }

        private void rate_btn_Click(object sender, EventArgs e)
        {
            var rating = 1;
            var userId = _parentWindow._user.Id;
            if (masterpiece_rbtn.Checked)
                rating = 5;
            else if (highlyRecommended_rbtn.Checked)
                rating = 4;
            else if (enjoyableRead_rbtn.Checked)
                rating = 3;
            else if (mediocreBook_rbtn.Checked)
                rating = 2;

            _bookService.RateBook(rating, userId, _book.Id);

            MessageBox.Show("Thanks for sharing your thoughts with us. We hope you found value in our book.",
                "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

            var updatedBook = _bookService.GetBook(_book.Id);
            var newRating = updatedBook.Rating.ToString() + "/5";
            rating_lbl.Text = newRating;
            _parentControl.rating_lbl.Text = newRating;
        }

        private void borrow_btn_Click(object sender, EventArgs e)
        {
            var result = _borrowBookService.Borrow(_parentWindow._user, _book);
            if (result != null)
            {
                MessageBox.Show(result, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show($"Success! You have successfully borrowed the book \"{_book.Title}\"",
                    "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                var updatedBook = _bookService.GetBook(_book.Id);
                var updatedBorrowStatistics = updatedBook.Quantity - updatedBook.AvailableQuantity;
                borrowed_lbl.Text = updatedBorrowStatistics.ToString();
                _parentControl.available_lbl.Text = updatedBook.AvailableQuantity > 0 ? "Available" : "Not Available";
            }
        }
    }
}
