namespace FrontEnd.Librarian_Window
{
    partial class AddBookWindow
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            title_lbl = new Label();
            title_tb = new TextBox();
            delete_btn = new Button();
            description_lbl = new Label();
            description_tb = new TextBox();
            genres_lb = new CheckedListBox();
            authors_cmb = new ComboBox();
            authors_lbl = new Label();
            quantity_num = new NumericUpDown();
            genres_lbl = new Label();
            quantity_lbl = new Label();
            add_btn = new Button();
            cancel_btn = new Button();
            ((System.ComponentModel.ISupportInitialize)quantity_num).BeginInit();
            SuspendLayout();
            // 
            // title_lbl
            // 
            title_lbl.AutoSize = true;
            title_lbl.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            title_lbl.Location = new Point(80, 75);
            title_lbl.Name = "title_lbl";
            title_lbl.Size = new Size(68, 37);
            title_lbl.TabIndex = 6;
            title_lbl.Text = "Title";
            // 
            // title_tb
            // 
            title_tb.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            title_tb.Location = new Point(80, 115);
            title_tb.MaxLength = 40;
            title_tb.Name = "title_tb";
            title_tb.Size = new Size(633, 43);
            title_tb.TabIndex = 7;
            // 
            // delete_btn
            // 
            delete_btn.ForeColor = Color.Firebrick;
            delete_btn.Location = new Point(638, 12);
            delete_btn.Name = "delete_btn";
            delete_btn.Size = new Size(150, 46);
            delete_btn.TabIndex = 8;
            delete_btn.Text = "Delete";
            delete_btn.UseVisualStyleBackColor = true;
            delete_btn.Click += delete_btn_Click;
            // 
            // description_lbl
            // 
            description_lbl.AutoSize = true;
            description_lbl.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            description_lbl.Location = new Point(80, 194);
            description_lbl.Name = "description_lbl";
            description_lbl.Size = new Size(152, 37);
            description_lbl.TabIndex = 9;
            description_lbl.Text = "Description";
            // 
            // description_tb
            // 
            description_tb.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            description_tb.Location = new Point(80, 234);
            description_tb.MaxLength = 40;
            description_tb.Name = "description_tb";
            description_tb.Size = new Size(633, 43);
            description_tb.TabIndex = 10;
            // 
            // genres_lb
            // 
            genres_lb.FormattingEnabled = true;
            genres_lb.Location = new Point(80, 473);
            genres_lb.Name = "genres_lb";
            genres_lb.Size = new Size(633, 184);
            genres_lb.TabIndex = 11;
            // 
            // authors_cmb
            // 
            authors_cmb.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            authors_cmb.FormattingEnabled = true;
            authors_cmb.Location = new Point(80, 352);
            authors_cmb.Name = "authors_cmb";
            authors_cmb.Size = new Size(633, 45);
            authors_cmb.TabIndex = 12;
            // 
            // authors_lbl
            // 
            authors_lbl.AutoSize = true;
            authors_lbl.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            authors_lbl.Location = new Point(80, 312);
            authors_lbl.Name = "authors_lbl";
            authors_lbl.Size = new Size(98, 37);
            authors_lbl.TabIndex = 13;
            authors_lbl.Text = "Author";
            // 
            // quantity_num
            // 
            quantity_num.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            quantity_num.Location = new Point(80, 741);
            quantity_num.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            quantity_num.Name = "quantity_num";
            quantity_num.Size = new Size(633, 43);
            quantity_num.TabIndex = 14;
            // 
            // genres_lbl
            // 
            genres_lbl.AutoSize = true;
            genres_lbl.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            genres_lbl.Location = new Point(80, 433);
            genres_lbl.Name = "genres_lbl";
            genres_lbl.Size = new Size(99, 37);
            genres_lbl.TabIndex = 15;
            genres_lbl.Text = "Genres";
            // 
            // quantity_lbl
            // 
            quantity_lbl.AutoSize = true;
            quantity_lbl.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            quantity_lbl.Location = new Point(79, 701);
            quantity_lbl.Name = "quantity_lbl";
            quantity_lbl.Size = new Size(119, 37);
            quantity_lbl.TabIndex = 16;
            quantity_lbl.Text = "Quantity";
            // 
            // add_btn
            // 
            add_btn.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            add_btn.Location = new Point(430, 846);
            add_btn.Name = "add_btn";
            add_btn.Size = new Size(283, 46);
            add_btn.TabIndex = 17;
            add_btn.Text = "Add";
            add_btn.UseVisualStyleBackColor = true;
            add_btn.Click += add_btn_Click;
            // 
            // cancel_btn
            // 
            cancel_btn.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            cancel_btn.Location = new Point(79, 846);
            cancel_btn.Name = "cancel_btn";
            cancel_btn.Size = new Size(283, 46);
            cancel_btn.TabIndex = 18;
            cancel_btn.Text = "Cancel";
            cancel_btn.UseVisualStyleBackColor = true;
            cancel_btn.Click += cancel_btn_Click;
            // 
            // AddBookWindow
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 952);
            Controls.Add(cancel_btn);
            Controls.Add(add_btn);
            Controls.Add(quantity_lbl);
            Controls.Add(genres_lbl);
            Controls.Add(quantity_num);
            Controls.Add(authors_lbl);
            Controls.Add(authors_cmb);
            Controls.Add(genres_lb);
            Controls.Add(description_tb);
            Controls.Add(description_lbl);
            Controls.Add(delete_btn);
            Controls.Add(title_tb);
            Controls.Add(title_lbl);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddBookWindow";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddBookWindow";
            FormClosed += AddBookWindow_FormClosed;
            Load += AddBookWindow_Load;
            ((System.ComponentModel.ISupportInitialize)quantity_num).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label title_lbl;
        private TextBox title_tb;
        private Button delete_btn;
        private Label description_lbl;
        private TextBox description_tb;
        private CheckedListBox genres_lb;
        private ComboBox authors_cmb;
        private Label authors_lbl;
        private NumericUpDown quantity_num;
        private Label genres_lbl;
        private Label quantity_lbl;
        private Button add_btn;
        private Button cancel_btn;
    }
}