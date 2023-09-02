using BackEnd.Models.Constants;
using BackEnd.Models.Entities;
using BackEnd.Services.Interfaces;

namespace FrontEnd.User_Window.UserControls
{
    public partial class LibraryBooks : UserControl
    {
        private readonly UserWindow _parentWindow;
        private readonly IBookService _bookService;
        private readonly IGenreService _genreService;
        private readonly IAuthorService _authorService;
        private readonly IBorrowBookService _borrowBookService;

        public LibraryBooks(IBookService bookService, IGenreService genreService, IAuthorService authorService,
            UserWindow parentWindow, IBorrowBookService borrowBookService)
        {
            InitializeComponent();
            _bookService = bookService;
            _genreService = genreService;
            _authorService = authorService;
            _parentWindow = parentWindow;
            _borrowBookService = borrowBookService;
        }

        public void InitializePage()
        {
            var authors = _authorService.GetAllAuthors();
            var genres = _genreService.GetAllGenres();
            var books = _bookService.GetAllBooks();

            FillAuthorsListBox(authors);
            FillGenresListBox(genres);
            FillBooksControl(books);
            FillRatingBox(5);


            ascending_btn.ForeColor = Color.Blue;
            ascending_btn.BackColor = Color.AliceBlue;
            ascending_btn.Enabled = false;
        }

        private void LibraryBooks_Load(object sender, EventArgs e)
        {
            InitializePage();
        }

        private void FillAuthorsListBox(List<Author> authors)
        {
            authors_lb.Items.Clear();
            foreach (Author author in authors)
                authors_lb.Items.Add(author);
        }

        private void FillGenresListBox(List<Genre> genres)
        {
            genres_lb.Items.Clear();
            foreach (var item in genres)
                genres_lb.Items.Add(item);
        }

        private void FillBooksControl(List<Book> books)
        {
            booksPanel.Controls.Clear();
            foreach (var item in books)
            {
                var bookView = new BookView(item, _authorService, _bookService, _parentWindow, this, null, _borrowBookService, false);
                booksPanel.Controls.Add(bookView);
            }
        }

        private void FillRatingBox(int rating)
        {
            rating_cmb.Items.Clear();   
            for (int i = 1; i <= rating; i++)
                rating_cmb.Items.Add(i.ToString());
        }

        private void ascending_btn_Click(object sender, EventArgs e)
        {
            descending_btn.BackColor = Color.White;
            descending_btn.ForeColor = Color.Black;
            descending_btn.Enabled = true;

            ascending_btn.ForeColor = Color.Blue;
            ascending_btn.BackColor = Color.AliceBlue;
            ascending_btn.Enabled = false;
        }

        private void descending_btn_Click(object sender, EventArgs e)
        {
            ascending_btn.BackColor = Color.White;
            ascending_btn.ForeColor = Color.Black;
            ascending_btn.Enabled = true;

            descending_btn.ForeColor = Color.Blue;
            descending_btn.BackColor = Color.AliceBlue;
            descending_btn.Enabled = false;
        }

        private void filter_btn_Click(object sender, EventArgs e)
        {
            var authorsId = authors_lb.CheckedItems
                .Cast<Author>()
                .Select(author => author.Id)
                .ToList();

            var genresId = genres_lb.CheckedItems
                .Cast<Genre>()
                .Select(genre => genre.Id)
                .ToList();

            var IsDescending = descending_btn.Enabled ? false : true;
            int? rating = rating_cmb.SelectedItem is null ? null : int.Parse(rating_cmb.SelectedItem.ToString());

            var filterModel = new BookFilterModel(authorsId, genresId, rating, IsDescending);
            var books = _bookService.FilterBook(filterModel);
            FillBooksControl(books);
        }

        private void clear_btn_Click(object sender, EventArgs e)
        {
            authors_lb.SelectedItems.Clear();
            for (var i = 0; i < authors_lb.Items.Count; i++)
                authors_lb.SetItemChecked(i, false);

            genres_lb.SelectedItems.Clear();
            for (var i = 0; i < genres_lb.Items.Count; i++)
                genres_lb.SetItemChecked(i, false);

            rating_cmb.SelectedItem = null;

            var books = _bookService.GetAllBooks();
            FillBooksControl(books);
        }

        private void search_btn_Click(object sender, EventArgs e)
        {
            var keyword = search_tb.Text;
            var books = _bookService.AdvancedSearch(keyword);
            FillBooksControl(books);
        }

        private void search_tb_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(search_tb.Text))
            {
                var books = _bookService.GetAllBooks();
                FillBooksControl(books);
            }
        }
    }
}