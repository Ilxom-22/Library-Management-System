namespace FrontEnd.Librarian_Window
{
    partial class AddAuthorWindow
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
            authorName_tb = new TextBox();
            authorLastName_tb = new TextBox();
            name_lbl = new Label();
            delete_btn = new Button();
            lastName_lbl = new Label();
            biography_lbl = new Label();
            dateOfBirth_dtp = new DateTimePicker();
            dateOfBirth_lbl = new Label();
            dateOfDeath_dtp = new DateTimePicker();
            dateOfDeath_lbl = new Label();
            add_btn = new Button();
            cancel_btn = new Button();
            biography_rtb = new RichTextBox();
            SuspendLayout();
            // 
            // authorName_tb
            // 
            authorName_tb.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            authorName_tb.Location = new Point(84, 112);
            authorName_tb.MaxLength = 40;
            authorName_tb.Name = "authorName_tb";
            authorName_tb.Size = new Size(633, 43);
            authorName_tb.TabIndex = 2;
            // 
            // authorLastName_tb
            // 
            authorLastName_tb.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            authorLastName_tb.Location = new Point(84, 234);
            authorLastName_tb.MaxLength = 40;
            authorLastName_tb.Name = "authorLastName_tb";
            authorLastName_tb.Size = new Size(633, 43);
            authorLastName_tb.TabIndex = 3;
            // 
            // name_lbl
            // 
            name_lbl.AutoSize = true;
            name_lbl.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            name_lbl.Location = new Point(84, 72);
            name_lbl.Name = "name_lbl";
            name_lbl.Size = new Size(88, 37);
            name_lbl.TabIndex = 5;
            name_lbl.Text = "Name";
            // 
            // delete_btn
            // 
            delete_btn.ForeColor = Color.Firebrick;
            delete_btn.Location = new Point(638, 12);
            delete_btn.Name = "delete_btn";
            delete_btn.Size = new Size(150, 46);
            delete_btn.TabIndex = 6;
            delete_btn.Text = "Delete";
            delete_btn.UseVisualStyleBackColor = true;
            delete_btn.Click += delete_btn_Click;
            // 
            // lastName_lbl
            // 
            lastName_lbl.AutoSize = true;
            lastName_lbl.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lastName_lbl.Location = new Point(84, 194);
            lastName_lbl.Name = "lastName_lbl";
            lastName_lbl.Size = new Size(142, 37);
            lastName_lbl.TabIndex = 7;
            lastName_lbl.Text = "Last Name";
            // 
            // biography_lbl
            // 
            biography_lbl.AutoSize = true;
            biography_lbl.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            biography_lbl.Location = new Point(84, 315);
            biography_lbl.Name = "biography_lbl";
            biography_lbl.Size = new Size(244, 37);
            biography_lbl.TabIndex = 8;
            biography_lbl.Text = "Biography (in brief)";
            // 
            // dateOfBirth_dtp
            // 
            dateOfBirth_dtp.CalendarFont = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dateOfBirth_dtp.Location = new Point(84, 626);
            dateOfBirth_dtp.Name = "dateOfBirth_dtp";
            dateOfBirth_dtp.Size = new Size(633, 39);
            dateOfBirth_dtp.TabIndex = 9;
            dateOfBirth_dtp.Value = new DateTime(2023, 8, 29, 7, 20, 55, 0);
            // 
            // dateOfBirth_lbl
            // 
            dateOfBirth_lbl.AutoSize = true;
            dateOfBirth_lbl.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dateOfBirth_lbl.Location = new Point(84, 586);
            dateOfBirth_lbl.Name = "dateOfBirth_lbl";
            dateOfBirth_lbl.Size = new Size(166, 37);
            dateOfBirth_lbl.TabIndex = 10;
            dateOfBirth_lbl.Text = "Date of Birth";
            // 
            // dateOfDeath_dtp
            // 
            dateOfDeath_dtp.CalendarFont = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dateOfDeath_dtp.Location = new Point(84, 756);
            dateOfDeath_dtp.Name = "dateOfDeath_dtp";
            dateOfDeath_dtp.Size = new Size(633, 39);
            dateOfDeath_dtp.TabIndex = 11;
            dateOfDeath_dtp.Value = new DateTime(2023, 8, 29, 7, 20, 55, 0);
            dateOfDeath_dtp.ValueChanged += dateOfDeath_dtp_ValueChanged;
            // 
            // dateOfDeath_lbl
            // 
            dateOfDeath_lbl.AutoSize = true;
            dateOfDeath_lbl.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dateOfDeath_lbl.Location = new Point(84, 704);
            dateOfDeath_lbl.Name = "dateOfDeath_lbl";
            dateOfDeath_lbl.Size = new Size(350, 37);
            dateOfDeath_lbl.TabIndex = 12;
            dateOfDeath_lbl.Text = "Date of Death (if applicable)";
            // 
            // add_btn
            // 
            add_btn.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            add_btn.Location = new Point(434, 902);
            add_btn.Name = "add_btn";
            add_btn.Size = new Size(283, 46);
            add_btn.TabIndex = 13;
            add_btn.Text = "Add";
            add_btn.UseVisualStyleBackColor = true;
            add_btn.Click += add_btn_Click;
            // 
            // cancel_btn
            // 
            cancel_btn.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            cancel_btn.Location = new Point(84, 902);
            cancel_btn.Name = "cancel_btn";
            cancel_btn.Size = new Size(283, 46);
            cancel_btn.TabIndex = 14;
            cancel_btn.Text = "Cancel";
            cancel_btn.UseVisualStyleBackColor = true;
            cancel_btn.Click += cancel_btn_Click;
            // 
            // biography_rtb
            // 
            biography_rtb.BorderStyle = BorderStyle.None;
            biography_rtb.Location = new Point(84, 355);
            biography_rtb.Name = "biography_rtb";
            biography_rtb.Size = new Size(633, 192);
            biography_rtb.TabIndex = 15;
            biography_rtb.Text = "";
            // 
            // AddAuthorWindow
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(745, 1014);
            Controls.Add(biography_rtb);
            Controls.Add(cancel_btn);
            Controls.Add(add_btn);
            Controls.Add(dateOfDeath_lbl);
            Controls.Add(dateOfDeath_dtp);
            Controls.Add(dateOfBirth_lbl);
            Controls.Add(dateOfBirth_dtp);
            Controls.Add(biography_lbl);
            Controls.Add(lastName_lbl);
            Controls.Add(delete_btn);
            Controls.Add(name_lbl);
            Controls.Add(authorLastName_tb);
            Controls.Add(authorName_tb);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddAuthorWindow";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddAuthorWindow";
            FormClosed += AddAuthorWindow_FormClosed;
            Load += AddAuthorWindow_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox authorName_tb;
        private TextBox authorLastName_tb;
        private Label name_lbl;
        private Button delete_btn;
        private Label lastName_lbl;
        private Label biography_lbl;
        private DateTimePicker dateOfBirth_dtp;
        private Label dateOfBirth_lbl;
        private DateTimePicker dateOfDeath_dtp;
        private Label dateOfDeath_lbl;
        private Button add_btn;
        private Button cancel_btn;
        private RichTextBox biography_rtb;
    }
}