using BackEnd.Models.Entities;
using BackEnd.Services.Interfaces;
using FrontEnd.Librarian_Window.UserControls;

namespace FrontEnd.Librarian_Window
{
    public partial class AddAuthorWindow : Form
    {
        private readonly Form _parentWindow;
        private readonly Dashboard _parentPage;
        private readonly IAuthorService _authorService;
        private readonly int? _authorId;
        private Author? _author;

        public AddAuthorWindow(Form parentWindow, Dashboard parentPage, IAuthorService authorService, int? itemId)
        {
            InitializeComponent();
            _parentWindow = parentWindow;
            _parentPage = parentPage;
            _authorService = authorService;
            _authorId = itemId;

            SetAppearance();
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddAuthorWindow_Load(object sender, EventArgs e)
        {
            _parentWindow.Enabled = false;
        }

        private void AddAuthorWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            _parentWindow.Enabled = true;
        }

        private void dateOfDeath_dtp_ValueChanged(object sender, EventArgs e)
        {
            dateOfDeath_dtp.CustomFormat = "MM/dd/yyyy";
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            if (_authorId == null)
                Add();
            else
                Save();

        }

        private void Add()
        {
            var name = authorName_tb.Text;
            var lastName = authorLastName_tb.Text;
            var biography = biography_rtb.Text;
            var dateOfBirth = dateOfBirth_dtp.Value;
            var dateOfDeath = dateOfDeath_dtp.Value;
            var defaultDate = dateOfDeath_dtp.MinDate;

            var result = _authorService.AddAuthor(name, lastName, biography, dateOfBirth,
                                                dateOfDeath == defaultDate ? null : dateOfDeath);

            if (result != null)
            {
                MessageBox.Show(result, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                _parentPage.InitializePage();
                Close();
            }
        }

        private void Save()
        {
            _author.Name = authorName_tb.Text;
            _author.LastName = authorLastName_tb.Text;
            _author.Biography = biography_rtb.Text;
            _author.DateOfBirth = dateOfBirth_dtp.Value;

            DateTime? dateOfDeath = dateOfDeath_dtp.Value;
            var defaultDate = dateOfDeath_dtp.MinDate;
            _author.DateOfDeath = dateOfDeath == defaultDate ? null : dateOfDeath;

            var result = _authorService.Update(_author);
            if (result != null)
            {
                MessageBox.Show(result, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                _parentPage.InitializePage();
                Close();
            }
        }

        private void SetAppearance()
        {
            dateOfBirth_dtp.Format = DateTimePickerFormat.Custom;
            dateOfBirth_dtp.CustomFormat = "MM/dd/yyyy";
            dateOfDeath_dtp.Format = DateTimePickerFormat.Custom;
            dateOfDeath_dtp.CustomFormat = "MM/dd/yyyy";

            if (_authorId == null)
            {
                dateOfDeath_dtp.Value = dateOfDeath_dtp.MinDate;
                dateOfDeath_dtp.CustomFormat = "  ";
                delete_btn.Hide();
            }
            else
            {
                _author = _authorService.GetAuthor((int)_authorId);
                add_btn.Text = "Save Changes";
                add_btn.ForeColor = Color.Green;

                authorName_tb.Text = _author.Name;
                authorLastName_tb.Text = _author.LastName;
                biography_rtb.Text = _author.Biography;
                dateOfBirth_dtp.Value = _author.DateOfBirth;

                if (_author.DateOfDeath != null)
                    dateOfDeath_dtp.Value = (DateTime)_author.DateOfDeath;
                else
                {
                    dateOfDeath_dtp.Value = dateOfDeath_dtp.MinDate;
                    dateOfDeath_dtp.CustomFormat = "  ";
                }
            }
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show($"Are you sure you want to delete \"{_author?.FullName}\" author?",
                "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Delete(_author.Id);
            }
        }

        private void Delete(int authorId)
        {
            var result = _authorService.Delete(_author.Id);
            if (result != null)
                MessageBox.Show(result,"Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                _parentPage.InitializePage();
                Close();
            }
        }
    }
}
