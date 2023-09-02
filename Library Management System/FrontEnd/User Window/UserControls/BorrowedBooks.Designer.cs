namespace FrontEnd.User_Window.UserControls
{
    partial class BorrowedBooks
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
            label6 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            booksPanel = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(1936, 27);
            label6.Name = "label6";
            label6.Size = new Size(141, 54);
            label6.TabIndex = 22;
            label6.Text = "Return";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(1645, 27);
            label4.Name = "label4";
            label4.Size = new Size(138, 54);
            label4.TabIndex = 17;
            label4.Text = "Rating";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(978, 27);
            label3.Name = "label3";
            label3.Size = new Size(129, 54);
            label3.TabIndex = 18;
            label3.Text = "Genre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(574, 27);
            label2.Name = "label2";
            label2.Size = new Size(146, 54);
            label2.TabIndex = 20;
            label2.Text = "Author";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(173, 27);
            label1.Name = "label1";
            label1.Size = new Size(99, 54);
            label1.TabIndex = 19;
            label1.Text = "Title";
            // 
            // booksPanel
            // 
            booksPanel.AutoScroll = true;
            booksPanel.Location = new Point(173, 99);
            booksPanel.Name = "booksPanel";
            booksPanel.Size = new Size(1953, 1146);
            booksPanel.TabIndex = 13;
            // 
            // BorrowedBooks
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(booksPanel);
            Name = "BorrowedBooks";
            Size = new Size(2275, 1294);
            Load += BorrowedBooks_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label6;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        public FlowLayoutPanel booksPanel;
    }
}
