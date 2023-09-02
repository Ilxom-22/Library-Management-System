namespace FrontEnd.Librarian_Window.UserControls
{
    partial class Dashboard
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            totalBooks_lbl = new Label();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            totalUniqueBooks_lbl = new Label();
            label3 = new Label();
            panel3 = new Panel();
            totalAvailableBooks_lbl = new Label();
            panel4 = new Panel();
            totalBorrowedBooks_lbl = new Label();
            label4 = new Label();
            panel5 = new Panel();
            totalAuthors_lbl = new Label();
            label5 = new Label();
            panel6 = new Panel();
            totalGenres_lbl = new Label();
            label6 = new Label();
            panel7 = new Panel();
            totalReaders_lbl = new Label();
            label7 = new Label();
            authorPanel = new FlowLayoutPanel();
            genrePanel = new FlowLayoutPanel();
            bookPanel = new FlowLayoutPanel();
            authors_lbl = new Label();
            books_lbl = new Label();
            genres_lbl = new Label();
            addBook_btn = new Button();
            addGenre_btn = new Button();
            addAuthor_btn = new Button();
            authorSearch_tb = new TextBox();
            authorSearch_btn = new Button();
            genreSearch_tb = new TextBox();
            genreSearch_btn = new Button();
            bookSearch_tb = new TextBox();
            bookSearch_btn = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.GradientActiveCaption;
            panel1.Controls.Add(totalBooks_lbl);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(23, 22);
            panel1.Name = "panel1";
            panel1.Size = new Size(288, 200);
            panel1.TabIndex = 0;
            // 
            // totalBooks_lbl
            // 
            totalBooks_lbl.AutoSize = true;
            totalBooks_lbl.Font = new Font("Arial Rounded MT Bold", 19.875F, FontStyle.Regular, GraphicsUnit.Point);
            totalBooks_lbl.Location = new Point(3, 91);
            totalBooks_lbl.Name = "totalBooks_lbl";
            totalBooks_lbl.Size = new Size(58, 61);
            totalBooks_lbl.TabIndex = 8;
            totalBooks_lbl.Text = "0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(3, 34);
            label2.Name = "label2";
            label2.Size = new Size(158, 37);
            label2.TabIndex = 7;
            label2.Text = "Total Books:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(3, 34);
            label1.Name = "label1";
            label1.Size = new Size(273, 37);
            label1.TabIndex = 0;
            label1.Text = "Total Available Books:";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.GradientActiveCaption;
            panel2.Controls.Add(totalUniqueBooks_lbl);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(343, 22);
            panel2.Name = "panel2";
            panel2.Size = new Size(288, 200);
            panel2.TabIndex = 1;
            // 
            // totalUniqueBooks_lbl
            // 
            totalUniqueBooks_lbl.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            totalUniqueBooks_lbl.AutoSize = true;
            totalUniqueBooks_lbl.Font = new Font("Arial Rounded MT Bold", 19.875F, FontStyle.Regular, GraphicsUnit.Point);
            totalUniqueBooks_lbl.Location = new Point(3, 91);
            totalUniqueBooks_lbl.Name = "totalUniqueBooks_lbl";
            totalUniqueBooks_lbl.Size = new Size(58, 61);
            totalUniqueBooks_lbl.TabIndex = 9;
            totalUniqueBooks_lbl.Text = "0";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(3, 34);
            label3.Name = "label3";
            label3.Size = new Size(251, 37);
            label3.TabIndex = 8;
            label3.Text = "Total Unique Books:";
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.GradientActiveCaption;
            panel3.Controls.Add(totalAvailableBooks_lbl);
            panel3.Controls.Add(label1);
            panel3.Location = new Point(667, 22);
            panel3.Name = "panel3";
            panel3.Size = new Size(288, 200);
            panel3.TabIndex = 2;
            // 
            // totalAvailableBooks_lbl
            // 
            totalAvailableBooks_lbl.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            totalAvailableBooks_lbl.AutoSize = true;
            totalAvailableBooks_lbl.Font = new Font("Arial Rounded MT Bold", 19.875F, FontStyle.Regular, GraphicsUnit.Point);
            totalAvailableBooks_lbl.Location = new Point(3, 91);
            totalAvailableBooks_lbl.Name = "totalAvailableBooks_lbl";
            totalAvailableBooks_lbl.Size = new Size(58, 61);
            totalAvailableBooks_lbl.TabIndex = 9;
            totalAvailableBooks_lbl.Text = "0";
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.GradientActiveCaption;
            panel4.Controls.Add(totalBorrowedBooks_lbl);
            panel4.Controls.Add(label4);
            panel4.Location = new Point(988, 22);
            panel4.Name = "panel4";
            panel4.Size = new Size(288, 200);
            panel4.TabIndex = 3;
            // 
            // totalBorrowedBooks_lbl
            // 
            totalBorrowedBooks_lbl.AutoSize = true;
            totalBorrowedBooks_lbl.Font = new Font("Arial Rounded MT Bold", 19.875F, FontStyle.Regular, GraphicsUnit.Point);
            totalBorrowedBooks_lbl.Location = new Point(3, 91);
            totalBorrowedBooks_lbl.Name = "totalBorrowedBooks_lbl";
            totalBorrowedBooks_lbl.Size = new Size(58, 61);
            totalBorrowedBooks_lbl.TabIndex = 9;
            totalBorrowedBooks_lbl.Text = "0";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(3, 34);
            label4.Name = "label4";
            label4.Size = new Size(280, 37);
            label4.TabIndex = 8;
            label4.Text = "Total Borrowed Books:";
            // 
            // panel5
            // 
            panel5.BackColor = SystemColors.GradientActiveCaption;
            panel5.Controls.Add(totalAuthors_lbl);
            panel5.Controls.Add(label5);
            panel5.Location = new Point(1312, 22);
            panel5.Name = "panel5";
            panel5.Size = new Size(288, 200);
            panel5.TabIndex = 4;
            // 
            // totalAuthors_lbl
            // 
            totalAuthors_lbl.AutoSize = true;
            totalAuthors_lbl.Font = new Font("Arial Rounded MT Bold", 19.875F, FontStyle.Regular, GraphicsUnit.Point);
            totalAuthors_lbl.Location = new Point(3, 91);
            totalAuthors_lbl.Name = "totalAuthors_lbl";
            totalAuthors_lbl.Size = new Size(58, 61);
            totalAuthors_lbl.TabIndex = 9;
            totalAuthors_lbl.Text = "0";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(3, 34);
            label5.Name = "label5";
            label5.Size = new Size(179, 37);
            label5.TabIndex = 8;
            label5.Text = "Total Authors:";
            // 
            // panel6
            // 
            panel6.BackColor = SystemColors.GradientActiveCaption;
            panel6.Controls.Add(totalGenres_lbl);
            panel6.Controls.Add(label6);
            panel6.Location = new Point(1633, 22);
            panel6.Name = "panel6";
            panel6.Size = new Size(288, 200);
            panel6.TabIndex = 5;
            // 
            // totalGenres_lbl
            // 
            totalGenres_lbl.AutoSize = true;
            totalGenres_lbl.Font = new Font("Arial Rounded MT Bold", 19.875F, FontStyle.Regular, GraphicsUnit.Point);
            totalGenres_lbl.Location = new Point(3, 91);
            totalGenres_lbl.Name = "totalGenres_lbl";
            totalGenres_lbl.Size = new Size(58, 61);
            totalGenres_lbl.TabIndex = 9;
            totalGenres_lbl.Text = "0";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(3, 34);
            label6.Name = "label6";
            label6.Size = new Size(169, 37);
            label6.TabIndex = 8;
            label6.Text = "Total Genres:";
            // 
            // panel7
            // 
            panel7.BackColor = SystemColors.GradientActiveCaption;
            panel7.Controls.Add(totalReaders_lbl);
            panel7.Controls.Add(label7);
            panel7.Location = new Point(1952, 22);
            panel7.Name = "panel7";
            panel7.Size = new Size(288, 200);
            panel7.TabIndex = 6;
            // 
            // totalReaders_lbl
            // 
            totalReaders_lbl.AutoSize = true;
            totalReaders_lbl.Font = new Font("Arial Rounded MT Bold", 19.875F, FontStyle.Regular, GraphicsUnit.Point);
            totalReaders_lbl.Location = new Point(3, 91);
            totalReaders_lbl.Name = "totalReaders_lbl";
            totalReaders_lbl.Size = new Size(58, 61);
            totalReaders_lbl.TabIndex = 9;
            totalReaders_lbl.Text = "0";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(3, 34);
            label7.Name = "label7";
            label7.Size = new Size(180, 37);
            label7.TabIndex = 8;
            label7.Text = "Total Readers:";
            // 
            // authorPanel
            // 
            authorPanel.AutoScroll = true;
            authorPanel.BorderStyle = BorderStyle.FixedSingle;
            authorPanel.Location = new Point(26, 407);
            authorPanel.Name = "authorPanel";
            authorPanel.Size = new Size(720, 795);
            authorPanel.TabIndex = 7;
            // 
            // genrePanel
            // 
            genrePanel.AutoScroll = true;
            genrePanel.BorderStyle = BorderStyle.FixedSingle;
            genrePanel.Location = new Point(774, 407);
            genrePanel.Name = "genrePanel";
            genrePanel.Size = new Size(720, 795);
            genrePanel.TabIndex = 8;
            // 
            // bookPanel
            // 
            bookPanel.AutoScroll = true;
            bookPanel.BorderStyle = BorderStyle.FixedSingle;
            bookPanel.Location = new Point(1520, 404);
            bookPanel.Name = "bookPanel";
            bookPanel.Size = new Size(720, 795);
            bookPanel.TabIndex = 9;
            // 
            // authors_lbl
            // 
            authors_lbl.AutoSize = true;
            authors_lbl.Font = new Font("Segoe UI", 17F, FontStyle.Regular, GraphicsUnit.Point);
            authors_lbl.ForeColor = Color.MidnightBlue;
            authors_lbl.Location = new Point(285, 269);
            authors_lbl.Name = "authors_lbl";
            authors_lbl.Size = new Size(188, 62);
            authors_lbl.TabIndex = 0;
            authors_lbl.Text = "Authors";
            // 
            // books_lbl
            // 
            books_lbl.AutoSize = true;
            books_lbl.Font = new Font("Segoe UI", 17F, FontStyle.Regular, GraphicsUnit.Point);
            books_lbl.ForeColor = Color.MidnightBlue;
            books_lbl.Location = new Point(1822, 269);
            books_lbl.Name = "books_lbl";
            books_lbl.Size = new Size(150, 62);
            books_lbl.TabIndex = 11;
            books_lbl.Text = "Books";
            books_lbl.TextAlign = ContentAlignment.TopCenter;
            // 
            // genres_lbl
            // 
            genres_lbl.AutoSize = true;
            genres_lbl.Font = new Font("Segoe UI", 17F, FontStyle.Regular, GraphicsUnit.Point);
            genres_lbl.ForeColor = Color.MidnightBlue;
            genres_lbl.Location = new Point(1081, 269);
            genres_lbl.Name = "genres_lbl";
            genres_lbl.Size = new Size(169, 62);
            genres_lbl.TabIndex = 12;
            genres_lbl.Text = "Genres";
            // 
            // addBook_btn
            // 
            addBook_btn.BackColor = SystemColors.ButtonFace;
            addBook_btn.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            addBook_btn.ForeColor = Color.DarkBlue;
            addBook_btn.Location = new Point(1952, 1208);
            addBook_btn.Name = "addBook_btn";
            addBook_btn.Size = new Size(288, 63);
            addBook_btn.TabIndex = 13;
            addBook_btn.Text = "Add a Book";
            addBook_btn.UseVisualStyleBackColor = false;
            addBook_btn.Click += addBook_btn_Click;
            // 
            // addGenre_btn
            // 
            addGenre_btn.BackColor = SystemColors.ButtonFace;
            addGenre_btn.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            addGenre_btn.ForeColor = Color.DarkBlue;
            addGenre_btn.Location = new Point(1206, 1208);
            addGenre_btn.Name = "addGenre_btn";
            addGenre_btn.Size = new Size(288, 63);
            addGenre_btn.TabIndex = 14;
            addGenre_btn.Text = "Add a Genre";
            addGenre_btn.UseVisualStyleBackColor = false;
            addGenre_btn.Click += addGenre_btn_Click;
            // 
            // addAuthor_btn
            // 
            addAuthor_btn.BackColor = SystemColors.ButtonFace;
            addAuthor_btn.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            addAuthor_btn.ForeColor = Color.DarkBlue;
            addAuthor_btn.Location = new Point(458, 1208);
            addAuthor_btn.Name = "addAuthor_btn";
            addAuthor_btn.Size = new Size(288, 63);
            addAuthor_btn.TabIndex = 15;
            addAuthor_btn.Text = "Add an Author";
            addAuthor_btn.UseVisualStyleBackColor = false;
            addAuthor_btn.Click += addAuthor_btn_Click;
            // 
            // authorSearch_tb
            // 
            authorSearch_tb.BackColor = SystemColors.ControlLight;
            authorSearch_tb.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            authorSearch_tb.Location = new Point(23, 358);
            authorSearch_tb.MaxLength = 40;
            authorSearch_tb.Name = "authorSearch_tb";
            authorSearch_tb.Size = new Size(564, 43);
            authorSearch_tb.TabIndex = 16;
            authorSearch_tb.TextChanged += authorSearch_tb_TextChanged;
            // 
            // authorSearch_btn
            // 
            authorSearch_btn.BackColor = SystemColors.ButtonFace;
            authorSearch_btn.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            authorSearch_btn.ForeColor = Color.DarkBlue;
            authorSearch_btn.Location = new Point(593, 358);
            authorSearch_btn.Name = "authorSearch_btn";
            authorSearch_btn.Size = new Size(150, 46);
            authorSearch_btn.TabIndex = 17;
            authorSearch_btn.Text = "Search";
            authorSearch_btn.UseVisualStyleBackColor = false;
            authorSearch_btn.Click += authorSearch_btn_Click;
            // 
            // genreSearch_tb
            // 
            genreSearch_tb.BackColor = SystemColors.ControlLight;
            genreSearch_tb.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            genreSearch_tb.Location = new Point(774, 358);
            genreSearch_tb.MaxLength = 40;
            genreSearch_tb.Name = "genreSearch_tb";
            genreSearch_tb.Size = new Size(564, 43);
            genreSearch_tb.TabIndex = 18;
            genreSearch_tb.TextChanged += genreSearch_tb_TextChanged;
            // 
            // genreSearch_btn
            // 
            genreSearch_btn.BackColor = SystemColors.ButtonFace;
            genreSearch_btn.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            genreSearch_btn.ForeColor = Color.DarkBlue;
            genreSearch_btn.Location = new Point(1344, 356);
            genreSearch_btn.Name = "genreSearch_btn";
            genreSearch_btn.Size = new Size(150, 46);
            genreSearch_btn.TabIndex = 19;
            genreSearch_btn.Text = "Search";
            genreSearch_btn.UseVisualStyleBackColor = false;
            genreSearch_btn.Click += genreSearch_btn_Click;
            // 
            // bookSearch_tb
            // 
            bookSearch_tb.BackColor = SystemColors.ControlLight;
            bookSearch_tb.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            bookSearch_tb.Location = new Point(1520, 355);
            bookSearch_tb.MaxLength = 40;
            bookSearch_tb.Name = "bookSearch_tb";
            bookSearch_tb.Size = new Size(564, 43);
            bookSearch_tb.TabIndex = 20;
            bookSearch_tb.TextChanged += bookSearch_tb_TextChanged;
            // 
            // bookSearch_btn
            // 
            bookSearch_btn.BackColor = SystemColors.ButtonFace;
            bookSearch_btn.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            bookSearch_btn.ForeColor = Color.DarkBlue;
            bookSearch_btn.Location = new Point(2090, 353);
            bookSearch_btn.Name = "bookSearch_btn";
            bookSearch_btn.Size = new Size(150, 46);
            bookSearch_btn.TabIndex = 21;
            bookSearch_btn.Text = "Search";
            bookSearch_btn.UseVisualStyleBackColor = false;
            bookSearch_btn.Click += bookSearch_btn_Click;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            BackgroundImageLayout = ImageLayout.None;
            Controls.Add(bookSearch_btn);
            Controls.Add(bookSearch_tb);
            Controls.Add(genreSearch_btn);
            Controls.Add(genreSearch_tb);
            Controls.Add(authorSearch_btn);
            Controls.Add(authorSearch_tb);
            Controls.Add(addAuthor_btn);
            Controls.Add(addGenre_btn);
            Controls.Add(addBook_btn);
            Controls.Add(genres_lbl);
            Controls.Add(books_lbl);
            Controls.Add(authors_lbl);
            Controls.Add(bookPanel);
            Controls.Add(genrePanel);
            Controls.Add(authorPanel);
            Controls.Add(panel7);
            Controls.Add(panel6);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "Dashboard";
            Size = new Size(2275, 1287);
            Load += Dashboard_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Label label1;
        private Panel panel6;
        private Panel panel7;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label totalBooks_lbl;
        private Label totalUniqueBooks_lbl;
        private Label totalAvailableBooks_lbl;
        private Label totalBorrowedBooks_lbl;
        private Label totalAuthors_lbl;
        private Label totalGenres_lbl;
        private Label totalReaders_lbl;
        private FlowLayoutPanel authorPanel;
        private FlowLayoutPanel genrePanel;
        private FlowLayoutPanel bookPanel;
        private Label authors_lbl;
        private Label books_lbl;
        private Label genres_lbl;
        private Button addBook_btn;
        private Button addGenre_btn;
        private Button addAuthor_btn;
        private TextBox authorSearch_tb;
        private Button authorSearch_btn;
        private TextBox genreSearch_tb;
        private Button genreSearch_btn;
        private TextBox bookSearch_tb;
        private Button bookSearch_btn;
    }
}
