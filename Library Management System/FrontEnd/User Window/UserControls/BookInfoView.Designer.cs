namespace FrontEnd.User_Window.UserControls
{
    partial class BookInfoView
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            bookName_lbl = new Label();
            description_lbl = new Label();
            authorName_lbl = new Label();
            panel3 = new Panel();
            totalQuantity_lbl = new Label();
            label2 = new Label();
            panel4 = new Panel();
            availableQuantity_lbl = new Label();
            label3 = new Label();
            panel5 = new Panel();
            borrowed_lbl = new Label();
            label5 = new Label();
            panel6 = new Panel();
            rating_lbl = new Label();
            label7 = new Label();
            bookDescription_rtb = new RichTextBox();
            authorBiography_rtb = new RichTextBox();
            disappointingRead_rbtn = new RadioButton();
            mediocreBook_rbtn = new RadioButton();
            enjoyableRead_rbtn = new RadioButton();
            highlyRecommended_rbtn = new RadioButton();
            masterpiece_rbtn = new RadioButton();
            rate_btn = new Button();
            label8 = new Label();
            back_btn = new Button();
            dataGridView1 = new DataGridView();
            Title = new DataGridViewTextBoxColumn();
            Genre = new DataGridViewTextBoxColumn();
            Rating = new DataGridViewTextBoxColumn();
            borrow_btn = new Button();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // bookName_lbl
            // 
            bookName_lbl.AutoSize = true;
            bookName_lbl.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            bookName_lbl.Location = new Point(712, 19);
            bookName_lbl.Name = "bookName_lbl";
            bookName_lbl.Size = new Size(228, 54);
            bookName_lbl.TabIndex = 0;
            bookName_lbl.Text = "Book Name";
            // 
            // description_lbl
            // 
            description_lbl.Anchor = AnchorStyles.None;
            description_lbl.AutoSize = true;
            description_lbl.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            description_lbl.Location = new Point(433, 129);
            description_lbl.Name = "description_lbl";
            description_lbl.Size = new Size(225, 54);
            description_lbl.TabIndex = 1;
            description_lbl.Text = "Description";
            // 
            // authorName_lbl
            // 
            authorName_lbl.Anchor = AnchorStyles.None;
            authorName_lbl.AutoSize = true;
            authorName_lbl.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            authorName_lbl.Location = new Point(1552, 129);
            authorName_lbl.Name = "authorName_lbl";
            authorName_lbl.Size = new Size(262, 54);
            authorName_lbl.TabIndex = 2;
            authorName_lbl.Text = "Author Name";
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.GradientActiveCaption;
            panel3.Controls.Add(totalQuantity_lbl);
            panel3.Controls.Add(label2);
            panel3.Location = new Point(14, 695);
            panel3.Name = "panel3";
            panel3.Size = new Size(251, 182);
            panel3.TabIndex = 5;
            // 
            // totalQuantity_lbl
            // 
            totalQuantity_lbl.AutoSize = true;
            totalQuantity_lbl.Font = new Font("Arial Rounded MT Bold", 19.875F, FontStyle.Regular, GraphicsUnit.Point);
            totalQuantity_lbl.Location = new Point(3, 91);
            totalQuantity_lbl.Name = "totalQuantity_lbl";
            totalQuantity_lbl.Size = new Size(58, 61);
            totalQuantity_lbl.TabIndex = 8;
            totalQuantity_lbl.Text = "0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(3, 34);
            label2.Name = "label2";
            label2.Size = new Size(189, 37);
            label2.TabIndex = 7;
            label2.Text = "Total Quantity:";
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.GradientActiveCaption;
            panel4.Controls.Add(availableQuantity_lbl);
            panel4.Controls.Add(label3);
            panel4.Location = new Point(301, 695);
            panel4.Name = "panel4";
            panel4.Size = new Size(248, 182);
            panel4.TabIndex = 6;
            // 
            // availableQuantity_lbl
            // 
            availableQuantity_lbl.AutoSize = true;
            availableQuantity_lbl.Font = new Font("Arial Rounded MT Bold", 19.875F, FontStyle.Regular, GraphicsUnit.Point);
            availableQuantity_lbl.Location = new Point(3, 91);
            availableQuantity_lbl.Name = "availableQuantity_lbl";
            availableQuantity_lbl.Size = new Size(58, 61);
            availableQuantity_lbl.TabIndex = 8;
            availableQuantity_lbl.Text = "0";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(0, 34);
            label3.Name = "label3";
            label3.Size = new Size(240, 37);
            label3.TabIndex = 7;
            label3.Text = "Available Quantity:";
            // 
            // panel5
            // 
            panel5.BackColor = SystemColors.GradientActiveCaption;
            panel5.Controls.Add(borrowed_lbl);
            panel5.Controls.Add(label5);
            panel5.Location = new Point(585, 695);
            panel5.Name = "panel5";
            panel5.Size = new Size(248, 182);
            panel5.TabIndex = 7;
            // 
            // borrowed_lbl
            // 
            borrowed_lbl.AutoSize = true;
            borrowed_lbl.Font = new Font("Arial Rounded MT Bold", 19.875F, FontStyle.Regular, GraphicsUnit.Point);
            borrowed_lbl.Location = new Point(3, 91);
            borrowed_lbl.Name = "borrowed_lbl";
            borrowed_lbl.Size = new Size(58, 61);
            borrowed_lbl.TabIndex = 8;
            borrowed_lbl.Text = "0";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(3, 34);
            label5.Name = "label5";
            label5.Size = new Size(138, 37);
            label5.TabIndex = 7;
            label5.Text = "Borrowed:";
            // 
            // panel6
            // 
            panel6.BackColor = SystemColors.GradientActiveCaption;
            panel6.Controls.Add(rating_lbl);
            panel6.Controls.Add(label7);
            panel6.Location = new Point(866, 695);
            panel6.Name = "panel6";
            panel6.Size = new Size(251, 182);
            panel6.TabIndex = 9;
            // 
            // rating_lbl
            // 
            rating_lbl.AutoSize = true;
            rating_lbl.Font = new Font("Arial Rounded MT Bold", 19.875F, FontStyle.Regular, GraphicsUnit.Point);
            rating_lbl.Location = new Point(3, 91);
            rating_lbl.Name = "rating_lbl";
            rating_lbl.Size = new Size(58, 61);
            rating_lbl.TabIndex = 8;
            rating_lbl.Text = "0";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(3, 34);
            label7.Name = "label7";
            label7.Size = new Size(100, 37);
            label7.TabIndex = 7;
            label7.Text = "Rating:";
            // 
            // bookDescription_rtb
            // 
            bookDescription_rtb.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            bookDescription_rtb.Location = new Point(17, 195);
            bookDescription_rtb.MaxLength = 2000;
            bookDescription_rtb.Name = "bookDescription_rtb";
            bookDescription_rtb.ReadOnly = true;
            bookDescription_rtb.Size = new Size(1100, 469);
            bookDescription_rtb.TabIndex = 10;
            bookDescription_rtb.Text = "";
            // 
            // authorBiography_rtb
            // 
            authorBiography_rtb.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            authorBiography_rtb.Location = new Point(1156, 195);
            authorBiography_rtb.MaxLength = 2000;
            authorBiography_rtb.Name = "authorBiography_rtb";
            authorBiography_rtb.ReadOnly = true;
            authorBiography_rtb.Size = new Size(1100, 469);
            authorBiography_rtb.TabIndex = 11;
            authorBiography_rtb.Text = "";
            // 
            // disappointingRead_rbtn
            // 
            disappointingRead_rbtn.AutoSize = true;
            disappointingRead_rbtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            disappointingRead_rbtn.Location = new Point(17, 914);
            disappointingRead_rbtn.Name = "disappointingRead_rbtn";
            disappointingRead_rbtn.Size = new Size(329, 49);
            disappointingRead_rbtn.TabIndex = 13;
            disappointingRead_rbtn.Text = "Disappointing Read";
            disappointingRead_rbtn.UseVisualStyleBackColor = true;
            // 
            // mediocreBook_rbtn
            // 
            mediocreBook_rbtn.AutoSize = true;
            mediocreBook_rbtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            mediocreBook_rbtn.Location = new Point(14, 969);
            mediocreBook_rbtn.Name = "mediocreBook_rbtn";
            mediocreBook_rbtn.Size = new Size(267, 49);
            mediocreBook_rbtn.TabIndex = 14;
            mediocreBook_rbtn.Text = "Mediocre Book";
            mediocreBook_rbtn.UseVisualStyleBackColor = true;
            // 
            // enjoyableRead_rbtn
            // 
            enjoyableRead_rbtn.AutoSize = true;
            enjoyableRead_rbtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            enjoyableRead_rbtn.Location = new Point(14, 1024);
            enjoyableRead_rbtn.Name = "enjoyableRead_rbtn";
            enjoyableRead_rbtn.Size = new Size(266, 49);
            enjoyableRead_rbtn.TabIndex = 15;
            enjoyableRead_rbtn.Text = "Enjoyable Read";
            enjoyableRead_rbtn.UseVisualStyleBackColor = true;
            // 
            // highlyRecommended_rbtn
            // 
            highlyRecommended_rbtn.AutoSize = true;
            highlyRecommended_rbtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            highlyRecommended_rbtn.Location = new Point(14, 1082);
            highlyRecommended_rbtn.Name = "highlyRecommended_rbtn";
            highlyRecommended_rbtn.Size = new Size(366, 49);
            highlyRecommended_rbtn.TabIndex = 16;
            highlyRecommended_rbtn.Text = "Highly Recommended";
            highlyRecommended_rbtn.UseVisualStyleBackColor = true;
            // 
            // masterpiece_rbtn
            // 
            masterpiece_rbtn.AutoSize = true;
            masterpiece_rbtn.Checked = true;
            masterpiece_rbtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            masterpiece_rbtn.Location = new Point(17, 1137);
            masterpiece_rbtn.Name = "masterpiece_rbtn";
            masterpiece_rbtn.Size = new Size(225, 49);
            masterpiece_rbtn.TabIndex = 17;
            masterpiece_rbtn.TabStop = true;
            masterpiece_rbtn.Text = "Masterpiece";
            masterpiece_rbtn.UseVisualStyleBackColor = true;
            // 
            // rate_btn
            // 
            rate_btn.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            rate_btn.Location = new Point(17, 1205);
            rate_btn.Name = "rate_btn";
            rate_btn.Size = new Size(363, 62);
            rate_btn.TabIndex = 18;
            rate_btn.Text = "Rate";
            rate_btn.UseVisualStyleBackColor = true;
            rate_btn.Click += rate_btn_Click;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.None;
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(1494, 695);
            label8.Name = "label8";
            label8.Size = new Size(436, 54);
            label8.TabIndex = 19;
            label8.Text = "All Books of the Author";
            // 
            // back_btn
            // 
            back_btn.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            back_btn.Location = new Point(17, 27);
            back_btn.Name = "back_btn";
            back_btn.Size = new Size(165, 46);
            back_btn.TabIndex = 20;
            back_btn.Text = "Back";
            back_btn.UseVisualStyleBackColor = true;
            back_btn.Click += back_btn_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Title, Genre, Rating });
            dataGridView1.Location = new Point(1156, 752);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.RowTemplate.Height = 41;
            dataGridView1.Size = new Size(1100, 515);
            dataGridView1.TabIndex = 21;
            // 
            // Title
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            Title.DefaultCellStyle = dataGridViewCellStyle1;
            Title.HeaderText = "Title";
            Title.MinimumWidth = 10;
            Title.Name = "Title";
            Title.ReadOnly = true;
            Title.Width = 380;
            // 
            // Genre
            // 
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            Genre.DefaultCellStyle = dataGridViewCellStyle2;
            Genre.HeaderText = "Genre";
            Genre.MinimumWidth = 10;
            Genre.Name = "Genre";
            Genre.ReadOnly = true;
            Genre.Width = 540;
            // 
            // Rating
            // 
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            Rating.DefaultCellStyle = dataGridViewCellStyle3;
            Rating.HeaderText = "Rating";
            Rating.MaxInputLength = 5;
            Rating.MinimumWidth = 10;
            Rating.Name = "Rating";
            Rating.ReadOnly = true;
            Rating.Width = 200;
            // 
            // borrow_btn
            // 
            borrow_btn.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            borrow_btn.ForeColor = SystemColors.HotTrack;
            borrow_btn.Location = new Point(754, 1205);
            borrow_btn.Name = "borrow_btn";
            borrow_btn.Size = new Size(363, 62);
            borrow_btn.TabIndex = 22;
            borrow_btn.Text = "Borrow";
            borrow_btn.UseVisualStyleBackColor = true;
            borrow_btn.Click += borrow_btn_Click;
            // 
            // BookInfoView
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            Controls.Add(borrow_btn);
            Controls.Add(dataGridView1);
            Controls.Add(back_btn);
            Controls.Add(label8);
            Controls.Add(rate_btn);
            Controls.Add(masterpiece_rbtn);
            Controls.Add(highlyRecommended_rbtn);
            Controls.Add(enjoyableRead_rbtn);
            Controls.Add(mediocreBook_rbtn);
            Controls.Add(disappointingRead_rbtn);
            Controls.Add(authorBiography_rtb);
            Controls.Add(bookDescription_rtb);
            Controls.Add(panel6);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(authorName_lbl);
            Controls.Add(description_lbl);
            Controls.Add(bookName_lbl);
            Name = "BookInfoView";
            Size = new Size(2275, 1294);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label bookName_lbl;
        private Label description_lbl;
        private Label authorName_lbl;
        private Panel panel3;
        private Label totalQuantity_lbl;
        private Label label2;
        private Panel panel4;
        private Label availableQuantity_lbl;
        private Label label3;
        private Panel panel5;
        private Label label5;
        private Panel panel6;
        private Label rating_lbl;
        private Label label7;
        private RichTextBox bookDescription_rtb;
        private RichTextBox authorBiography_rtb;
        private RadioButton disappointingRead_rbtn;
        private RadioButton mediocreBook_rbtn;
        private RadioButton enjoyableRead_rbtn;
        private RadioButton highlyRecommended_rbtn;
        private RadioButton masterpiece_rbtn;
        private Button rate_btn;
        private Label label8;
        private Button back_btn;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Title;
        private DataGridViewTextBoxColumn Genre;
        private DataGridViewTextBoxColumn Rating;
        private Button borrow_btn;
        public Label borrowed_lbl;
    }
}
