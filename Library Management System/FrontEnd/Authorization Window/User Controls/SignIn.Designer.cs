namespace FrontEnd.Authorization_Page.User_Controls
{
    partial class SignIn
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
            signIn_lbl = new Label();
            username_lbl = new Label();
            username_tb = new TextBox();
            password_lbl = new Label();
            password_tb = new TextBox();
            cancel_btn = new Button();
            signIn_btn = new Button();
            SuspendLayout();
            // 
            // signIn_lbl
            // 
            signIn_lbl.AutoSize = true;
            signIn_lbl.Font = new Font("Segoe UI", 17F, FontStyle.Regular, GraphicsUnit.Point);
            signIn_lbl.Location = new Point(352, 93);
            signIn_lbl.Name = "signIn_lbl";
            signIn_lbl.Size = new Size(166, 62);
            signIn_lbl.TabIndex = 1;
            signIn_lbl.Text = "Sign In";
            // 
            // username_lbl
            // 
            username_lbl.AutoSize = true;
            username_lbl.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            username_lbl.Location = new Point(119, 222);
            username_lbl.Name = "username_lbl";
            username_lbl.Size = new Size(136, 37);
            username_lbl.TabIndex = 4;
            username_lbl.Text = "Username";
            // 
            // username_tb
            // 
            username_tb.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            username_tb.Location = new Point(119, 272);
            username_tb.MaxLength = 45;
            username_tb.Name = "username_tb";
            username_tb.Size = new Size(645, 43);
            username_tb.TabIndex = 5;
            // 
            // password_lbl
            // 
            password_lbl.AutoSize = true;
            password_lbl.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            password_lbl.Location = new Point(119, 380);
            password_lbl.Name = "password_lbl";
            password_lbl.Size = new Size(128, 37);
            password_lbl.TabIndex = 6;
            password_lbl.Text = "Password";
            // 
            // password_tb
            // 
            password_tb.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            password_tb.Location = new Point(119, 434);
            password_tb.MaxLength = 25;
            password_tb.Name = "password_tb";
            password_tb.Size = new Size(645, 43);
            password_tb.TabIndex = 7;
            // 
            // cancel_btn
            // 
            cancel_btn.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            cancel_btn.Location = new Point(119, 706);
            cancel_btn.Name = "cancel_btn";
            cancel_btn.Size = new Size(306, 58);
            cancel_btn.TabIndex = 10;
            cancel_btn.Text = "Cancel";
            cancel_btn.UseVisualStyleBackColor = true;
            cancel_btn.Click += cancel_btn_Click;
            // 
            // signIn_btn
            // 
            signIn_btn.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            signIn_btn.Location = new Point(458, 706);
            signIn_btn.Name = "signIn_btn";
            signIn_btn.Size = new Size(306, 58);
            signIn_btn.TabIndex = 9;
            signIn_btn.Text = "Sign In";
            signIn_btn.UseVisualStyleBackColor = true;
            signIn_btn.Click += signIn_btn_Click;
            // 
            // SignIn
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(cancel_btn);
            Controls.Add(signIn_btn);
            Controls.Add(password_tb);
            Controls.Add(password_lbl);
            Controls.Add(username_tb);
            Controls.Add(username_lbl);
            Controls.Add(signIn_lbl);
            Name = "SignIn";
            Size = new Size(895, 868);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label signIn_lbl;
        private Label username_lbl;
        private TextBox username_tb;
        private Label password_lbl;
        private TextBox password_tb;
        private Button cancel_btn;
        private Button signIn_btn;
    }
}
