namespace QuanLyCuaHang
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            panel2 = new Panel();
            label3 = new Label();
            label2 = new Label();
            label5 = new Label();
            txtUserName = new TextBox();
            txtPassword = new TextBox();
            btnSignUp = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Highlight;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(5, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(274, 441);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 81);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(274, 191);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label1.ForeColor = Color.Snow;
            label1.Location = new Point(3, 275);
            label1.Name = "label1";
            label1.Size = new Size(267, 115);
            label1.TabIndex = 0;
            label1.Text = "Phần Mềm Quản Lý Cửa Hàng";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnSignUp);
            panel2.Controls.Add(txtPassword);
            panel2.Controls.Add(txtUserName);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(285, 5);
            panel2.Name = "panel2";
            panel2.Size = new Size(409, 441);
            panel2.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.Control;
            label3.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label3.ForeColor = SystemColors.Highlight;
            label3.Location = new Point(33, 163);
            label3.Name = "label3";
            label3.Size = new Size(132, 25);
            label3.TabIndex = 3;
            label3.Text = "UserName :";
            // 
            // label2
            // 
            label2.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label2.ForeColor = SystemColors.Highlight;
            label2.Location = new Point(3, 22);
            label2.Name = "label2";
            label2.Size = new Size(406, 72);
            label2.TabIndex = 2;
            label2.Text = "Sign Up";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            label2.Click += label2_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.Control;
            label5.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label5.ForeColor = SystemColors.Highlight;
            label5.Location = new Point(33, 247);
            label5.Name = "label5";
            label5.Size = new Size(123, 25);
            label5.TabIndex = 5;
            label5.Text = "Password :";
            // 
            // txtUserName
            // 
            txtUserName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtUserName.BorderStyle = BorderStyle.FixedSingle;
            txtUserName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtUserName.Location = new Point(33, 191);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(359, 34);
            txtUserName.TabIndex = 6;
            // 
            // txtPassword
            // 
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtPassword.Location = new Point(33, 275);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(359, 34);
            txtPassword.TabIndex = 7;
            // 
            // btnSignUp
            // 
            btnSignUp.BackColor = SystemColors.Highlight;
            btnSignUp.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnSignUp.ForeColor = SystemColors.HighlightText;
            btnSignUp.Location = new Point(118, 348);
            btnSignUp.Name = "btnSignUp";
            btnSignUp.Size = new Size(168, 65);
            btnSignUp.TabIndex = 8;
            btnSignUp.Text = "Sign Up";
            btnSignUp.UseVisualStyleBackColor = false;
            btnSignUp.Click += btnSignUp_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(699, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Cửa hàng hoa của Đạt";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label3;
        private Label label5;
        private Button btnSignUp;
        private TextBox txtPassword;
        private TextBox txtUserName;
    }
}
