namespace FrontEnd.Authorization_Page
{
    partial class Verification
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
            label1 = new Label();
            label2 = new Label();
            maskedCode_tb = new MaskedTextBox();
            back_btn = new Button();
            confirm_btn = new Button();
            varification_lbl = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(39, 242);
            label1.Name = "label1";
            label1.Size = new Size(586, 37);
            label1.TabIndex = 0;
            label1.Text = "We've sent a 6-digit code to your email address.";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(39, 304);
            label2.Name = "label2";
            label2.Size = new Size(849, 37);
            label2.TabIndex = 1;
            label2.Text = "Please check your inbox and enter the code below to verify your email.";
            // 
            // maskedCode_tb
            // 
            maskedCode_tb.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            maskedCode_tb.Location = new Point(39, 480);
            maskedCode_tb.Mask = "000000";
            maskedCode_tb.Name = "maskedCode_tb";
            maskedCode_tb.Size = new Size(410, 61);
            maskedCode_tb.TabIndex = 0;
            maskedCode_tb.ValidatingType = typeof(int);
            // 
            // back_btn
            // 
            back_btn.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            back_btn.Location = new Point(39, 754);
            back_btn.Name = "back_btn";
            back_btn.Size = new Size(176, 61);
            back_btn.TabIndex = 2;
            back_btn.Text = "Back";
            back_btn.UseVisualStyleBackColor = true;
            back_btn.Click += back_btn_Click;
            // 
            // confirm_btn
            // 
            confirm_btn.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            confirm_btn.Location = new Point(549, 480);
            confirm_btn.Name = "confirm_btn";
            confirm_btn.Size = new Size(176, 61);
            confirm_btn.TabIndex = 3;
            confirm_btn.Text = "Confirm";
            confirm_btn.UseVisualStyleBackColor = true;
            // 
            // varification_lbl
            // 
            varification_lbl.AutoSize = true;
            varification_lbl.Font = new Font("Segoe UI", 17F, FontStyle.Regular, GraphicsUnit.Point);
            varification_lbl.Location = new Point(300, 83);
            varification_lbl.Name = "varification_lbl";
            varification_lbl.Size = new Size(253, 62);
            varification_lbl.TabIndex = 4;
            varification_lbl.Text = "Verification";
            // 
            // Verification
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(varification_lbl);
            Controls.Add(confirm_btn);
            Controls.Add(back_btn);
            Controls.Add(maskedCode_tb);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Verification";
            Size = new Size(895, 868);
            Load += Verification_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private MaskedTextBox maskedCode_tb;
        private Button back_btn;
        private Button confirm_btn;
        private Label varification_lbl;
    }
}
