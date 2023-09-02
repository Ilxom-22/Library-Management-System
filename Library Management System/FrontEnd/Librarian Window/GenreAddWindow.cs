using BackEnd.Models.Entities;
using BackEnd.Services.Interfaces;
using FrontEnd.Librarian_Window.UserControls;

namespace FrontEnd.Librarian_Window
{
    public partial class GenreAddWindow : Form
    {
        private readonly Form _parentWindow;
        private readonly Dashboard _parentPage;
        private readonly IGenreService _genreService;
        private readonly int? _genreId;
        private Genre? _genre;

        public GenreAddWindow(Form parentWindow, Dashboard parentPage, IGenreService genreService, int? itemId)
        {
            InitializeComponent();

            _parentWindow = parentWindow;
            _parentPage = parentPage;
            _genreService = genreService;
            _genreId = itemId;

            InitializeWindow();
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            if (_genreId == null)
            {
                var result = _genreService.AddGenre(genreName_tb.Text);
                if (result != null)
                    MessageBox.Show(result, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    _parentPage.InitializePage();
                    Close();
                }
                return;
            }

            _genre.Name = genreName_tb.Text;
            var updateResult = _genreService.Update(_genre);
            if (updateResult != null)
                MessageBox.Show(updateResult, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                _parentPage.InitializePage();
                Close();
            }
        }

        private void GenreAddWindow_Load(object sender, EventArgs e)
        {
            _parentWindow.Enabled = false;
        }

        private void GenreAddWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            _parentWindow.Enabled = true;
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show($"Are you sure you want to delete \"{_genre?.Name}\" genre?", 
                "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                DeleteGenre(_genre.Id);
            }
        }

        private void DeleteGenre(int genreId)
        {
            var result = _genreService.Delete(genreId);
            if (result != null)
                MessageBox.Show(result, "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                _parentPage.InitializePage();
                Close();
            }
        }

        private void InitializeWindow()
        {
            if (_genreId == null)
            {
                delete_btn.Hide();
                return;
            }

            add_btn.Text = "Save Changes";
            add_btn.ForeColor = Color.Green;
            _genre = _genreService.GetGenre((int)_genreId);
            genreName_tb.Text = _genre?.Name;
        }
    }
}