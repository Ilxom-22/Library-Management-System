namespace FrontEnd.User_Window.UserControls
{
    partial class LibraryBooks
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
            search_tb = new TextBox();
            search_btn = new Button();
            authors_lb = new CheckedListBox();
            genres_lb = new CheckedListBox();
            rating_cmb = new ComboBox();
            filter_btn = new Button();
            clear_btn = new Button();
            authors_lbl = new Label();
            ascending_btn = new Button();
            descending_btn = new Button();
            genres_lbl = new Label();
            rating_lbl = new Label();
            booksPanel = new FlowLayoutPanel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // search_tb
            // 
            search_tb.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            search_tb.Location = new Point(675, 20);
            search_tb.MaxLength = 40;
            search_tb.Name = "search_tb";
            search_tb.Size = new Size(814, 43);
            search_tb.TabIndex = 0;
            search_tb.TextChanged += search_tb_TextChanged;
            // 
            // search_btn
            // 
            search_btn.Location = new Point(1509, 17);
            search_btn.Name = "search_btn";
            search_btn.Size = new Size(150, 46);
            search_btn.TabIndex = 1;
            search_btn.Text = "Search";
            search_btn.UseVisualStyleBackColor = true;
            search_btn.Click += search_btn_Click;
            // 
            // authors_lb
            // 
            authors_lb.AllowDrop = true;
            authors_lb.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            authors_lb.FormattingEnabled = true;
            authors_lb.Location = new Point(15, 141);
            authors_lb.Name = "authors_lb";
            authors_lb.Size = new Size(277, 400);
            authors_lb.TabIndex = 2;
            // 
            // genres_lb
            // 
            genres_lb.FormattingEnabled = true;
            genres_lb.Location = new Point(15, 619);
            genres_lb.Name = "genres_lb";
            genres_lb.Size = new Size(277, 400);
            genres_lb.TabIndex = 3;
            // 
            // rating_cmb
            // 
            rating_cmb.FormattingEnabled = true;
            rating_cmb.Location = new Point(15, 1078);
            rating_cmb.Name = "rating_cmb";
            rating_cmb.Size = new Size(277, 40);
            rating_cmb.TabIndex = 4;
            // 
            // filter_btn
            // 
            filter_btn.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            filter_btn.Location = new Point(15, 20);
            filter_btn.Name = "filter_btn";
            filter_btn.Size = new Size(150, 46);
            filter_btn.TabIndex = 5;
            filter_btn.Text = "Filter";
            filter_btn.UseVisualStyleBackColor = true;
            filter_btn.Click += filter_btn_Click;
            // 
            // clear_btn
            // 
            clear_btn.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            clear_btn.Location = new Point(182, 20);
            clear_btn.Name = "clear_btn";
            clear_btn.Size = new Size(110, 46);
            clear_btn.TabIndex = 6;
            clear_btn.Text = "Clear";
            clear_btn.UseVisualStyleBackColor = true;
            clear_btn.Click += clear_btn_Click;
            // 
            // authors_lbl
            // 
            authors_lbl.AutoSize = true;
            authors_lbl.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            authors_lbl.Location = new Point(94, 101);
            authors_lbl.Name = "authors_lbl";
            authors_lbl.Size = new Size(109, 37);
            authors_lbl.TabIndex = 7;
            authors_lbl.Text = "Authors";
            // 
            // ascending_btn
            // 
            ascending_btn.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            ascending_btn.Location = new Point(15, 1171);
            ascending_btn.Name = "ascending_btn";
            ascending_btn.Size = new Size(277, 46);
            ascending_btn.TabIndex = 8;
            ascending_btn.Text = "Ascending";
            ascending_btn.UseVisualStyleBackColor = true;
            ascending_btn.Click += ascending_btn_Click;
            // 
            // descending_btn
            // 
            descending_btn.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            descending_btn.Location = new Point(15, 1223);
            descending_btn.Name = "descending_btn";
            descending_btn.Size = new Size(277, 46);
            descending_btn.TabIndex = 9;
            descending_btn.Text = "Descending";
            descending_btn.UseVisualStyleBackColor = true;
            descending_btn.Click += descending_btn_Click;
            // 
            // genres_lbl
            // 
            genres_lbl.AutoSize = true;
            genres_lbl.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            genres_lbl.Location = new Point(94, 579);
            genres_lbl.Name = "genres_lbl";
            genres_lbl.Size = new Size(99, 37);
            genres_lbl.TabIndex = 10;
            genres_lbl.Text = "Genres";
            // 
            // rating_lbl
            // 
            rating_lbl.AutoSize = true;
            rating_lbl.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            rating_lbl.Location = new Point(99, 1038);
            rating_lbl.Name = "rating_lbl";
            rating_lbl.Size = new Size(94, 37);
            rating_lbl.TabIndex = 11;
            rating_lbl.Text = "Rating";
            // 
            // booksPanel
            // 
            booksPanel.AutoScroll = true;
            booksPanel.Location = new Point(309, 145);
            booksPanel.Name = "booksPanel";
            booksPanel.Size = new Size(1953, 1146);
            booksPanel.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(309, 88);
            label1.Name = "label1";
            label1.Size = new Size(99, 54);
            label1.TabIndex = 13;
            label1.Text = "Title";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(710, 88);
            label2.Name = "label2";
            label2.Size = new Size(146, 54);
            label2.TabIndex = 14;
            label2.Text = "Author";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(1114, 88);
            label3.Name = "label3";
            label3.Size = new Size(129, 54);
            label3.TabIndex = 8;
            label3.Text = "Genre";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(1781, 88);
            label4.Name = "label4";
            label4.Size = new Size(138, 54);
            label4.TabIndex = 8;
            label4.Text = "Rating";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(2113, 88);
            label5.Name = "label5";
            label5.Size = new Size(149, 54);
            label5.TabIndex = 15;
            label5.Text = "Borrow";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(1925, 88);
            label6.Name = "label6";
            label6.Size = new Size(182, 54);
            label6.TabIndex = 16;
            label6.Text = "Available";
            // 
            // LibraryBooks
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(booksPanel);
            Controls.Add(rating_lbl);
            Controls.Add(genres_lbl);
            Controls.Add(descending_btn);
            Controls.Add(ascending_btn);
            Controls.Add(authors_lbl);
            Controls.Add(clear_btn);
            Controls.Add(filter_btn);
            Controls.Add(rating_cmb);
            Controls.Add(genres_lb);
            Controls.Add(authors_lb);
            Controls.Add(search_btn);
            Controls.Add(search_tb);
            Name = "LibraryBooks";
            Size = new Size(2275, 1294);
            Load += LibraryBooks_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox search_tb;
        private Button search_btn;
        private CheckedListBox authors_lb;
        private CheckedListBox genres_lb;
        private ComboBox rating_cmb;
        private Button filter_btn;
        private Button clear_btn;
        private Label authors_lbl;
        private Button ascending_btn;
        private Button descending_btn;
        private Label genres_lbl;
        private Label rating_lbl;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        public FlowLayoutPanel booksPanel;
    }
}
