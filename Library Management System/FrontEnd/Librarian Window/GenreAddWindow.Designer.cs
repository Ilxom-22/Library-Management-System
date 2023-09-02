namespace FrontEnd.Librarian_Window
{
    partial class GenreAddWindow
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
            add_btn = new Button();
            genreName_tb = new TextBox();
            genreName_lbl = new Label();
            cancel_btn = new Button();
            delete_btn = new Button();
            SuspendLayout();
            // 
            // add_btn
            // 
            add_btn.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            add_btn.Location = new Point(421, 263);
            add_btn.Name = "add_btn";
            add_btn.Size = new Size(283, 46);
            add_btn.TabIndex = 0;
            add_btn.Text = "Add";
            add_btn.UseVisualStyleBackColor = true;
            add_btn.Click += add_btn_Click;
            // 
            // genreName_tb
            // 
            genreName_tb.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            genreName_tb.Location = new Point(71, 119);
            genreName_tb.MaxLength = 40;
            genreName_tb.Name = "genreName_tb";
            genreName_tb.Size = new Size(633, 43);
            genreName_tb.TabIndex = 1;
            // 
            // genreName_lbl
            // 
            genreName_lbl.AutoSize = true;
            genreName_lbl.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            genreName_lbl.Location = new Point(71, 69);
            genreName_lbl.Name = "genreName_lbl";
            genreName_lbl.Size = new Size(166, 37);
            genreName_lbl.TabIndex = 2;
            genreName_lbl.Text = "Genre Name";
            // 
            // cancel_btn
            // 
            cancel_btn.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            cancel_btn.Location = new Point(71, 263);
            cancel_btn.Name = "cancel_btn";
            cancel_btn.Size = new Size(283, 46);
            cancel_btn.TabIndex = 3;
            cancel_btn.Text = "Cancel";
            cancel_btn.UseVisualStyleBackColor = true;
            cancel_btn.Click += cancel_btn_Click;
            // 
            // delete_btn
            // 
            delete_btn.ForeColor = Color.Firebrick;
            delete_btn.Location = new Point(638, 12);
            delete_btn.Name = "delete_btn";
            delete_btn.Size = new Size(150, 46);
            delete_btn.TabIndex = 4;
            delete_btn.Text = "Delete";
            delete_btn.UseVisualStyleBackColor = true;
            delete_btn.Click += delete_btn_Click;
            // 
            // GenreAddWindow
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 374);
            Controls.Add(delete_btn);
            Controls.Add(cancel_btn);
            Controls.Add(genreName_lbl);
            Controls.Add(genreName_tb);
            Controls.Add(add_btn);
            FormBorderStyle = FormBorderStyle.None;
            Name = "GenreAddWindow";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GenreAddWindow";
            FormClosed += GenreAddWindow_FormClosed;
            Load += GenreAddWindow_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button add_btn;
        private TextBox genreName_tb;
        private Label genreName_lbl;
        private Button cancel_btn;
        private Button delete_btn;
    }
}