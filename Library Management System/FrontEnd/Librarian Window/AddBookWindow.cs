using BackEnd.Models.Entities;
using BackEnd.Services.Interfaces;
using FrontEnd.Librarian_Window.UserControls;

namespace FrontEnd.Librarian_Window
{
    public partial class AddBookWindow : Form
    {
        private readonly Form _parentWindow;
        private readonly Dashboard _parentPage;
        private readonly IBookService _bookService;
        private readonly IGenreService _genreService;
        private readonly IAuthorService _authorService;
        private int? _bookId;
        private Book? _book;

        public AddBookWindow(Form parentWindow, Dashboard parentPage, IBookService bookService,
            IGenreService genreService, IAuthorService authorService, int? bookId)
        {
            InitializeComponent();
            _parentWindow = parentWindow;
            _parentPage = parentPage;
            _bookService = bookService;
            _genreService = genreService;
            _authorService = authorService;
            _bookId = bookId;

            SetAppearance();
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddBookWindow_Load(object sender, EventArgs e)
        {
            _parentWindow.Enabled = false;
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            if (_bookId == null)
                Add();
            else
                Save();
        }

        private void Add()
        {
            var title = title_tb.Text;
            var description = description_tb.Text;
            var author = authors_cmb.SelectedItem as Author;
            var quantity = (int)quantity_num.Value;
            List<int> genresId = new List<int>();
            foreach (Genre genre in genres_lb.CheckedItems)
                genresId.Add(genre.Id);

            var result = _bookService.AddBook(title, description, author.Id, quantity, genresId);

            if (result != null)
                MessageBox.Show(result, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                _parentPage.InitializePage();
                Close();
            }
        }

        private void Save()
        {
            _book.Title = title_tb.Text;
            _book.Description = description_tb.Text;
            _book.AuthorId = (authors_cmb.SelectedItem as Author).Id;
            _book.Quantity = (int)quantity_num.Value;
            List<int> genresId = new List<int>();
            foreach (Genre genre in genres_lb.CheckedItems)
                genresId.Add(genre.Id);

            var result = _bookService.Update(_book, genresId);

            if (result != null)
                MessageBox.Show(result, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                _parentPage.InitializePage();
                Close();
            }
        }

        private void SetAppearance()
        {
            var authors = _authorService.GetAllAuthors();
            var genres = _genreService.GetAllGenres();
            InitializeAuthorsList(authors);
            InitializeGenresList(genres);

            if (_bookId == null)
            {
                delete_btn.Hide();
            }
            else
            {
                add_btn.Text = "Save Changes";
                add_btn.ForeColor = Color.Green;

                _book = _bookService.GetBook((int)_bookId);
                var relatedGenres = _bookService.GetBookGenres(_book.Id);

                title_tb.Text = _book.Title;
                description_tb.Text = _book.Description;
                quantity_num.Value = _book.Quantity;
                PutBookAuthor(_authorService.GetAuthor(_book.AuthorId));
                PutBookGenres(relatedGenres);
            }
        }

        private void InitializeAuthorsList(List<Author> authors)
        {
            authors_cmb.Items.Clear();
            foreach (var author in authors)
                authors_cmb.Items.Add(author);

            authors_cmb.SelectedIndex = 0;
        }

        private void InitializeGenresList(List<Genre> genres)
        {
            genres_lb.Items.Clear();
            foreach (var genre in genres)
                genres_lb.Items.Add(genre);
        }

        private void PutBookAuthor(Author author)
        {
            authors_cmb.SelectedItem = author;
        }

        private void AddBookWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            _parentWindow.Enabled = true;
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show($"Are you sure you want to delete \"{_book?.Title}\" book?",
               "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
                DeleteBook(_book.Id);
        }

        private void DeleteBook(int bookId)
        {
            var result = _bookService.Delete(bookId);
            if (result != null)
                MessageBox.Show(result, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                _parentPage.InitializePage();
                Close();
            }
        }

        private void PutBookGenres(List<Genre> genres)
        {
            foreach (var genre in genres)
            {
                var index = IndexOfItemInListBox(genre);
                genres_lb.SetItemChecked(index, true);
            }
        }

        private int IndexOfItemInListBox(Genre genre)
        {
            for (var i = 0; i < genres_lb.Items.Count; i++)
            {
                if ((genres_lb.Items[i] as Genre)?.Id == genre.Id)
                    return i;
            }

            return -1;
        }
    }
}
