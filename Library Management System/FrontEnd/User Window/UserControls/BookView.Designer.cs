namespace FrontEnd.User_Window.UserControls
{
    partial class BookView
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
            tableLayoutPanel1 = new TableLayoutPanel();
            borrow_btn = new Button();
            available_lbl = new Label();
            rating_lbl = new Label();
            genre_lbl = new Label();
            author_lbl = new Label();
            title_lbl = new Label();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.BackColor = SystemColors.ButtonHighlight;
            tableLayoutPanel1.ColumnCount = 6;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 400F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 400F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 668F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 150F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 150F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 150F));
            tableLayoutPanel1.Controls.Add(borrow_btn, 5, 0);
            tableLayoutPanel1.Controls.Add(available_lbl, 4, 0);
            tableLayoutPanel1.Controls.Add(rating_lbl, 3, 0);
            tableLayoutPanel1.Controls.Add(genre_lbl, 2, 0);
            tableLayoutPanel1.Controls.Add(author_lbl, 1, 0);
            tableLayoutPanel1.Controls.Add(title_lbl, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1919, 100);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // borrow_btn
            // 
            borrow_btn.Anchor = AnchorStyles.None;
            borrow_btn.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            borrow_btn.Location = new Point(1786, 23);
            borrow_btn.Name = "borrow_btn";
            borrow_btn.Size = new Size(114, 54);
            borrow_btn.TabIndex = 6;
            borrow_btn.Text = "Borrow";
            borrow_btn.UseVisualStyleBackColor = true;
            borrow_btn.Click += borrow_btn_Click;
            // 
            // available_lbl
            // 
            available_lbl.Anchor = AnchorStyles.None;
            available_lbl.AutoSize = true;
            available_lbl.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            available_lbl.Location = new Point(1630, 13);
            available_lbl.MaximumSize = new Size(590, 0);
            available_lbl.Name = "available_lbl";
            available_lbl.Size = new Size(125, 74);
            available_lbl.TabIndex = 5;
            available_lbl.Text = "Not Available";
            // 
            // rating_lbl
            // 
            rating_lbl.Anchor = AnchorStyles.None;
            rating_lbl.AutoSize = true;
            rating_lbl.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            rating_lbl.Location = new Point(1514, 31);
            rating_lbl.MaximumSize = new Size(590, 0);
            rating_lbl.Name = "rating_lbl";
            rating_lbl.Size = new Size(58, 37);
            rating_lbl.TabIndex = 4;
            rating_lbl.Text = "1/5";
            // 
            // genre_lbl
            // 
            genre_lbl.Anchor = AnchorStyles.Left;
            genre_lbl.AutoSize = true;
            genre_lbl.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            genre_lbl.Location = new Point(803, 31);
            genre_lbl.MaximumSize = new Size(590, 0);
            genre_lbl.Name = "genre_lbl";
            genre_lbl.Size = new Size(88, 37);
            genre_lbl.TabIndex = 3;
            genre_lbl.Text = "Genre";
            // 
            // author_lbl
            // 
            author_lbl.Anchor = AnchorStyles.Left;
            author_lbl.AutoSize = true;
            author_lbl.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            author_lbl.Location = new Point(403, 31);
            author_lbl.MaximumSize = new Size(590, 0);
            author_lbl.Name = "author_lbl";
            author_lbl.Size = new Size(98, 37);
            author_lbl.TabIndex = 2;
            author_lbl.Text = "Author";
            // 
            // title_lbl
            // 
            title_lbl.Anchor = AnchorStyles.Left;
            title_lbl.AutoSize = true;
            title_lbl.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            title_lbl.Location = new Point(3, 31);
            title_lbl.MaximumSize = new Size(590, 0);
            title_lbl.Name = "title_lbl";
            title_lbl.Size = new Size(68, 37);
            title_lbl.TabIndex = 1;
            title_lbl.Text = "Title";
            // 
            // BookView
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.Gainsboro;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(tableLayoutPanel1);
            Cursor = Cursors.Hand;
            Name = "BookView";
            Size = new Size(1919, 100);
            Load += BookView_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label author_lbl;
        private Label title_lbl;
        private Label genre_lbl;
        private Button borrow_btn;
        public Label rating_lbl;
        public Label available_lbl;
    }
}
