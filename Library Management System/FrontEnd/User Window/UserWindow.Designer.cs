namespace FrontEnd.User_Window
{
    partial class UserWindow
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
            menuPanel = new Panel();
            luminaLib_lbl = new Label();
            borrowedBooks_btn = new Button();
            logout_btn = new Button();
            books_btn = new Button();
            mainPanel = new Panel();
            menuPanel.SuspendLayout();
            SuspendLayout();
            // 
            // menuPanel
            // 
            menuPanel.BorderStyle = BorderStyle.FixedSingle;
            menuPanel.Controls.Add(luminaLib_lbl);
            menuPanel.Controls.Add(borrowedBooks_btn);
            menuPanel.Controls.Add(logout_btn);
            menuPanel.Controls.Add(books_btn);
            menuPanel.Location = new Point(0, -5);
            menuPanel.Name = "menuPanel";
            menuPanel.Size = new Size(409, 1308);
            menuPanel.TabIndex = 1;
            // 
            // luminaLib_lbl
            // 
            luminaLib_lbl.AutoSize = true;
            luminaLib_lbl.Font = new Font("Stencil", 20F, FontStyle.Regular, GraphicsUnit.Point);
            luminaLib_lbl.ForeColor = Color.DeepSkyBlue;
            luminaLib_lbl.Location = new Point(47, 68);
            luminaLib_lbl.Name = "luminaLib_lbl";
            luminaLib_lbl.Size = new Size(311, 64);
            luminaLib_lbl.TabIndex = 4;
            luminaLib_lbl.Text = "LuminaLib";
            // 
            // borrowedBooks_btn
            // 
            borrowedBooks_btn.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            borrowedBooks_btn.Location = new Point(10, 537);
            borrowedBooks_btn.Name = "borrowedBooks_btn";
            borrowedBooks_btn.Size = new Size(394, 58);
            borrowedBooks_btn.TabIndex = 2;
            borrowedBooks_btn.Text = "Borrowed Books";
            borrowedBooks_btn.UseVisualStyleBackColor = true;
            borrowedBooks_btn.Click += borrowedBooks_btn_Click;
            // 
            // logout_btn
            // 
            logout_btn.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            logout_btn.ForeColor = Color.Firebrick;
            logout_btn.Location = new Point(10, 1215);
            logout_btn.Name = "logout_btn";
            logout_btn.Size = new Size(394, 58);
            logout_btn.TabIndex = 1;
            logout_btn.Text = "Logout";
            logout_btn.UseVisualStyleBackColor = true;
            logout_btn.Click += logout_btn_Click;
            // 
            // books_btn
            // 
            books_btn.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            books_btn.Location = new Point(10, 473);
            books_btn.Name = "books_btn";
            books_btn.Size = new Size(394, 58);
            books_btn.TabIndex = 0;
            books_btn.Text = "Books";
            books_btn.UseVisualStyleBackColor = true;
            books_btn.Click += books_btn_Click;
            // 
            // mainPanel
            // 
            mainPanel.AutoScroll = true;
            mainPanel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            mainPanel.Location = new Point(411, -5);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(2275, 1294);
            mainPanel.TabIndex = 2;
            // 
            // UserWindow
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2684, 1289);
            Controls.Add(mainPanel);
            Controls.Add(menuPanel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "UserWindow";
            Text = "UserWindow";
            FormClosing += UserWindow_FormClosing;
            Load += UserWindow_Load;
            menuPanel.ResumeLayout(false);
            menuPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel menuPanel;
        private Label luminaLib_lbl;
        private Button borrowedBooks_btn;
        private Button logout_btn;
        private Button books_btn;
        public Panel mainPanel;
    }
}