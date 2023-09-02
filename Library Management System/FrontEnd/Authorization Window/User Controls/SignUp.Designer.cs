namespace FrontEnd.Authorization_Page
{
    partial class SignUp
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
            signUp_lbl = new Label();
            email_tb = new TextBox();
            email_lbl = new Label();
            username_lbl = new Label();
            username_tb = new TextBox();
            password_lbl = new Label();
            password_tb = new TextBox();
            signUp_btn = new Button();
            cancel_btn = new Button();
            firstName_lbl = new Label();
            lastName_lbl = new Label();
            firstName_tb = new TextBox();
            lastName_tb = new TextBox();
            SuspendLayout();
            // 
            // signUp_lbl
            // 
            signUp_lbl.AutoSize = true;
            signUp_lbl.Font = new Font("Segoe UI", 17F, FontStyle.Regular, GraphicsUnit.Point);
            signUp_lbl.Location = new Point(345, 22);
            signUp_lbl.Name = "signUp_lbl";
            signUp_lbl.Size = new Size(187, 62);
            signUp_lbl.TabIndex = 0;
            signUp_lbl.Text = "Sign Up";
            // 
            // email_tb
            // 
            email_tb.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            email_tb.Location = new Point(132, 376);
            email_tb.MaxLength = 318;
            email_tb.Name = "email_tb";
            email_tb.Size = new Size(645, 43);
            email_tb.TabIndex = 1;
            // 
            // email_lbl
            // 
            email_lbl.AutoSize = true;
            email_lbl.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            email_lbl.Location = new Point(132, 336);
            email_lbl.Name = "email_lbl";
            email_lbl.Size = new Size(183, 37);
            email_lbl.TabIndex = 2;
            email_lbl.Text = "Email Address";
            // 
            // username_lbl
            // 
            username_lbl.AutoSize = true;
            username_lbl.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            username_lbl.Location = new Point(132, 466);
            username_lbl.Name = "username_lbl";
            username_lbl.Size = new Size(136, 37);
            username_lbl.TabIndex = 3;
            username_lbl.Text = "Username";
            // 
            // username_tb
            // 
            username_tb.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            username_tb.Location = new Point(132, 506);
            username_tb.MaxLength = 45;
            username_tb.Name = "username_tb";
            username_tb.Size = new Size(645, 43);
            username_tb.TabIndex = 4;
            // 
            // password_lbl
            // 
            password_lbl.AutoSize = true;
            password_lbl.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            password_lbl.Location = new Point(132, 597);
            password_lbl.Name = "password_lbl";
            password_lbl.Size = new Size(128, 37);
            password_lbl.TabIndex = 5;
            password_lbl.Text = "Password";
            // 
            // password_tb
            // 
            password_tb.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            password_tb.Location = new Point(132, 637);
            password_tb.MaxLength = 25;
            password_tb.Name = "password_tb";
            password_tb.Size = new Size(645, 43);
            password_tb.TabIndex = 6;
            // 
            // signUp_btn
            // 
            signUp_btn.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            signUp_btn.Location = new Point(471, 749);
            signUp_btn.Name = "signUp_btn";
            signUp_btn.Size = new Size(306, 58);
            signUp_btn.TabIndex = 7;
            signUp_btn.Text = "Sign Up";
            signUp_btn.UseVisualStyleBackColor = true;
            signUp_btn.Click += signUp_btn_Click;
            // 
            // cancel_btn
            // 
            cancel_btn.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            cancel_btn.Location = new Point(132, 749);
            cancel_btn.Name = "cancel_btn";
            cancel_btn.Size = new Size(306, 58);
            cancel_btn.TabIndex = 8;
            cancel_btn.Text = "Cancel";
            cancel_btn.UseVisualStyleBackColor = true;
            cancel_btn.Click += cancel_btn_Click;
            // 
            // firstName_lbl
            // 
            firstName_lbl.AutoSize = true;
            firstName_lbl.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            firstName_lbl.Location = new Point(132, 93);
            firstName_lbl.Name = "firstName_lbl";
            firstName_lbl.Size = new Size(144, 37);
            firstName_lbl.TabIndex = 9;
            firstName_lbl.Text = "First Name";
            // 
            // lastName_lbl
            // 
            lastName_lbl.AutoSize = true;
            lastName_lbl.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lastName_lbl.Location = new Point(132, 215);
            lastName_lbl.Name = "lastName_lbl";
            lastName_lbl.Size = new Size(142, 37);
            lastName_lbl.TabIndex = 10;
            lastName_lbl.Text = "Last Name";
            // 
            // firstName_tb
            // 
            firstName_tb.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            firstName_tb.Location = new Point(132, 133);
            firstName_tb.MaxLength = 40;
            firstName_tb.Name = "firstName_tb";
            firstName_tb.Size = new Size(645, 43);
            firstName_tb.TabIndex = 11;
            // 
            // lastName_tb
            // 
            lastName_tb.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lastName_tb.Location = new Point(132, 255);
            lastName_tb.MaxLength = 40;
            lastName_tb.Name = "lastName_tb";
            lastName_tb.Size = new Size(645, 43);
            lastName_tb.TabIndex = 12;
            // 
            // SignUp
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lastName_tb);
            Controls.Add(firstName_tb);
            Controls.Add(lastName_lbl);
            Controls.Add(firstName_lbl);
            Controls.Add(cancel_btn);
            Controls.Add(signUp_btn);
            Controls.Add(password_tb);
            Controls.Add(password_lbl);
            Controls.Add(username_tb);
            Controls.Add(username_lbl);
            Controls.Add(email_lbl);
            Controls.Add(email_tb);
            Controls.Add(signUp_lbl);
            Name = "SignUp";
            Size = new Size(895, 868);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label signUp_lbl;
        private TextBox email_tb;
        private Label email_lbl;
        private Label username_lbl;
        private TextBox username_tb;
        private Label password_lbl;
        private TextBox password_tb;
        private Button signUp_btn;
        private Button cancel_btn;
        private Label firstName_lbl;
        private Label lastName_lbl;
        private TextBox firstName_tb;
        private TextBox lastName_tb;
    }
}
