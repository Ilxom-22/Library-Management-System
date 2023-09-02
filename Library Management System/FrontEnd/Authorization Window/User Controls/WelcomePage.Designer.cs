namespace FrontEnd.Authorization_Page
{
    partial class WelcomePage
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
            welcomeLibrary_lbl = new Label();
            signUp_btn = new Button();
            signIn_btn = new Button();
            exit_btn = new Button();
            SuspendLayout();
            // 
            // welcomeLibrary_lbl
            // 
            welcomeLibrary_lbl.AutoSize = true;
            welcomeLibrary_lbl.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            welcomeLibrary_lbl.Location = new Point(138, 196);
            welcomeLibrary_lbl.Name = "welcomeLibrary_lbl";
            welcomeLibrary_lbl.Size = new Size(604, 72);
            welcomeLibrary_lbl.TabIndex = 1;
            welcomeLibrary_lbl.Text = "Welcome to our Library!";
            // 
            // signUp_btn
            // 
            signUp_btn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            signUp_btn.Location = new Point(234, 378);
            signUp_btn.Name = "signUp_btn";
            signUp_btn.Size = new Size(415, 75);
            signUp_btn.TabIndex = 2;
            signUp_btn.Text = "Sign Up";
            signUp_btn.UseVisualStyleBackColor = true;
            signUp_btn.Click += signUp_btn_Click;
            // 
            // signIn_btn
            // 
            signIn_btn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            signIn_btn.Location = new Point(234, 487);
            signIn_btn.Name = "signIn_btn";
            signIn_btn.Size = new Size(415, 75);
            signIn_btn.TabIndex = 3;
            signIn_btn.Text = "Sign In";
            signIn_btn.UseVisualStyleBackColor = true;
            signIn_btn.Click += signIn_btn_Click;
            // 
            // exit_btn
            // 
            exit_btn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            exit_btn.Location = new Point(234, 682);
            exit_btn.Name = "exit_btn";
            exit_btn.Size = new Size(415, 75);
            exit_btn.TabIndex = 4;
            exit_btn.Text = "Exit";
            exit_btn.UseVisualStyleBackColor = true;
            exit_btn.Click += exit_btn_Click;
            // 
            // WelcomePage
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(exit_btn);
            Controls.Add(signIn_btn);
            Controls.Add(signUp_btn);
            Controls.Add(welcomeLibrary_lbl);
            Name = "WelcomePage";
            Size = new Size(895, 868);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label welcomeLibrary_lbl;
        private Button signUp_btn;
        private Button signIn_btn;
        private Button exit_btn;
    }
}
