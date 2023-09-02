namespace FrontEnd.Librarian_Window.UserControls
{
    partial class UserActions
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
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            historyPanel = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(31, 50);
            label2.Name = "label2";
            label2.Size = new Size(99, 54);
            label2.TabIndex = 20;
            label2.Text = "Title";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(502, 50);
            label1.Name = "label1";
            label1.Size = new Size(146, 54);
            label1.TabIndex = 21;
            label1.Text = "Author";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(932, 50);
            label3.Name = "label3";
            label3.Size = new Size(129, 54);
            label3.TabIndex = 22;
            label3.Text = "Genre";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(1512, 50);
            label4.Name = "label4";
            label4.Size = new Size(106, 54);
            label4.TabIndex = 23;
            label4.Text = "Date";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(1664, 50);
            label5.Name = "label5";
            label5.Size = new Size(200, 54);
            label5.TabIndex = 24;
            label5.Text = "Username";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(2063, 50);
            label6.Name = "label6";
            label6.Size = new Size(137, 54);
            label6.TabIndex = 25;
            label6.Text = "Action";
            // 
            // historyPanel
            // 
            historyPanel.AutoScroll = true;
            historyPanel.Location = new Point(31, 107);
            historyPanel.Name = "historyPanel";
            historyPanel.Size = new Size(2213, 1166);
            historyPanel.TabIndex = 26;
            // 
            // UserActions
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(historyPanel);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(label2);
            Name = "UserActions";
            Size = new Size(2275, 1294);
            Load += UserActions_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private FlowLayoutPanel historyPanel;
    }
}
