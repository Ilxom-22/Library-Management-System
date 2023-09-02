namespace FrontEnd.Librarian_Window.UserControls
{
    partial class Action
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
            title_lbl = new Label();
            genre_lbl = new Label();
            author_lbl = new Label();
            action_lbl = new Label();
            date_lbl = new Label();
            username_lbl = new Label();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.ColumnCount = 6;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 470F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 430F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 530F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 200F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 400F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 140F));
            tableLayoutPanel1.Controls.Add(title_lbl, 0, 0);
            tableLayoutPanel1.Controls.Add(genre_lbl, 2, 0);
            tableLayoutPanel1.Controls.Add(author_lbl, 1, 0);
            tableLayoutPanel1.Controls.Add(action_lbl, 5, 0);
            tableLayoutPanel1.Controls.Add(date_lbl, 3, 0);
            tableLayoutPanel1.Controls.Add(username_lbl, 4, 0);
            tableLayoutPanel1.Dock = DockStyle.Left;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(2170, 100);
            tableLayoutPanel1.TabIndex = 0;
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
            title_lbl.TabIndex = 2;
            title_lbl.Text = "Title";
            // 
            // genre_lbl
            // 
            genre_lbl.Anchor = AnchorStyles.Left;
            genre_lbl.AutoSize = true;
            genre_lbl.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            genre_lbl.Location = new Point(903, 31);
            genre_lbl.MaximumSize = new Size(590, 0);
            genre_lbl.Name = "genre_lbl";
            genre_lbl.Size = new Size(88, 37);
            genre_lbl.TabIndex = 4;
            genre_lbl.Text = "Genre";
            // 
            // author_lbl
            // 
            author_lbl.Anchor = AnchorStyles.Left;
            author_lbl.AutoSize = true;
            author_lbl.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            author_lbl.Location = new Point(473, 31);
            author_lbl.MaximumSize = new Size(590, 0);
            author_lbl.Name = "author_lbl";
            author_lbl.Size = new Size(98, 37);
            author_lbl.TabIndex = 3;
            author_lbl.Text = "Author";
            // 
            // action_lbl
            // 
            action_lbl.Anchor = AnchorStyles.None;
            action_lbl.AutoSize = true;
            action_lbl.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            action_lbl.Location = new Point(2034, 31);
            action_lbl.MaximumSize = new Size(590, 0);
            action_lbl.Name = "action_lbl";
            action_lbl.Size = new Size(132, 37);
            action_lbl.TabIndex = 5;
            action_lbl.Text = "Borrowed";
            // 
            // date_lbl
            // 
            date_lbl.Anchor = AnchorStyles.None;
            date_lbl.AutoSize = true;
            date_lbl.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            date_lbl.Location = new Point(1493, 31);
            date_lbl.MaximumSize = new Size(590, 0);
            date_lbl.Name = "date_lbl";
            date_lbl.Size = new Size(73, 37);
            date_lbl.TabIndex = 7;
            date_lbl.Text = "Date";
            // 
            // username_lbl
            // 
            username_lbl.Anchor = AnchorStyles.Left;
            username_lbl.AutoSize = true;
            username_lbl.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            username_lbl.Location = new Point(1633, 31);
            username_lbl.MaximumSize = new Size(590, 0);
            username_lbl.Name = "username_lbl";
            username_lbl.Size = new Size(136, 37);
            username_lbl.TabIndex = 6;
            username_lbl.Text = "Username";
            // 
            // Action
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(tableLayoutPanel1);
            Name = "Action";
            Size = new Size(2173, 100);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label title_lbl;
        private Label author_lbl;
        private Label date_lbl;
        private Label username_lbl;
        private Label action_lbl;
        private Label genre_lbl;
    }
}
