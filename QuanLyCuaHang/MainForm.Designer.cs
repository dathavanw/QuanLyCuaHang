namespace QuanLyCuaHang
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            panel1 = new Panel();
            panel4 = new Panel();
            label1 = new Label();
            panel5 = new Panel();
            label2 = new Label();
            btnSuppliers = new Button();
            btnOrders = new Button();
            btnProduct = new Button();
            btnCustomers = new Button();
            panelShow = new Panel();
            panel6 = new Panel();
            btnInvoices = new Button();
            panel2 = new Panel();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            btnQuanLyKhachHangMenu = new Button();
            button1 = new Button();
            panel3 = new Panel();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panelShow.SuspendLayout();
            panel6.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(btnSuppliers);
            panel1.Controls.Add(btnOrders);
            panel1.Controls.Add(btnProduct);
            panel1.Controls.Add(btnCustomers);
            panel1.Controls.Add(panelShow);
            panel1.Location = new Point(229, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(805, 498);
            panel1.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel4.BackColor = SystemColors.HotTrack;
            panel4.Controls.Add(label1);
            panel4.Location = new Point(2, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(803, 109);
            panel4.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(38, 34);
            label1.Name = "label1";
            label1.Size = new Size(256, 38);
            label1.TabIndex = 2;
            label1.Text = "Welcome Admin";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel5
            // 
            panel5.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel5.BackColor = SystemColors.Highlight;
            panel5.Controls.Add(label2);
            panel5.Location = new Point(0, 460);
            panel5.Name = "panel5";
            panel5.Size = new Size(805, 38);
            panel5.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(12, 7);
            label2.Name = "label2";
            label2.Size = new Size(312, 23);
            label2.TabIndex = 1;
            label2.Text = "Địa chỉ : Quảng Xương - Thanh Hóa";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnSuppliers
            // 
            btnSuppliers.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSuppliers.BackColor = SystemColors.MenuHighlight;
            btnSuppliers.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold);
            btnSuppliers.ForeColor = SystemColors.Window;
            btnSuppliers.Location = new Point(564, 295);
            btnSuppliers.Name = "btnSuppliers";
            btnSuppliers.Size = new Size(194, 67);
            btnSuppliers.TabIndex = 5;
            btnSuppliers.Text = "Nhà Cung Cấp";
            btnSuppliers.UseVisualStyleBackColor = false;
            // 
            // btnOrders
            // 
            btnOrders.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnOrders.BackColor = SystemColors.MenuHighlight;
            btnOrders.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold);
            btnOrders.ForeColor = SystemColors.Window;
            btnOrders.Location = new Point(345, 295);
            btnOrders.Name = "btnOrders";
            btnOrders.Size = new Size(198, 67);
            btnOrders.TabIndex = 4;
            btnOrders.Text = "Nhập Hàng";
            btnOrders.UseVisualStyleBackColor = false;
            // 
            // btnProduct
            // 
            btnProduct.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnProduct.BackColor = SystemColors.MenuHighlight;
            btnProduct.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold);
            btnProduct.ForeColor = SystemColors.Window;
            btnProduct.Location = new Point(564, 174);
            btnProduct.Name = "btnProduct";
            btnProduct.Size = new Size(194, 67);
            btnProduct.TabIndex = 2;
            btnProduct.Text = "Quản Lý Sản Phẩm";
            btnProduct.UseVisualStyleBackColor = false;
            // 
            // btnCustomers
            // 
            btnCustomers.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCustomers.BackColor = SystemColors.MenuHighlight;
            btnCustomers.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold);
            btnCustomers.ForeColor = SystemColors.Window;
            btnCustomers.Location = new Point(345, 174);
            btnCustomers.Name = "btnCustomers";
            btnCustomers.Size = new Size(198, 67);
            btnCustomers.TabIndex = 1;
            btnCustomers.Text = "Quản Lý Khách Hàng";
            btnCustomers.UseVisualStyleBackColor = false;
            btnCustomers.Click += btnCustomers_Click;
            // 
            // panelShow
            // 
            panelShow.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelShow.Controls.Add(panel6);
            panelShow.Location = new Point(0, 115);
            panelShow.Name = "panelShow";
            panelShow.Size = new Size(805, 381);
            panelShow.TabIndex = 7;
            // 
            // panel6
            // 
            panel6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel6.Controls.Add(btnInvoices);
            panel6.Location = new Point(3, 3);
            panel6.Name = "panel6";
            panel6.Size = new Size(799, 345);
            panel6.TabIndex = 0;
            // 
            // btnInvoices
            // 
            btnInvoices.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnInvoices.BackColor = SystemColors.MenuHighlight;
            btnInvoices.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold);
            btnInvoices.ForeColor = SystemColors.Window;
            btnInvoices.Location = new Point(67, 58);
            btnInvoices.Name = "btnInvoices";
            btnInvoices.Size = new Size(240, 186);
            btnInvoices.TabIndex = 3;
            btnInvoices.Text = "Tạo Hóa Đơn";
            btnInvoices.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.AutoScroll = true;
            panel2.Controls.Add(button6);
            panel2.Controls.Add(button5);
            panel2.Controls.Add(button4);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(btnQuanLyKhachHangMenu);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(panel3);
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(222, 497);
            panel2.TabIndex = 2;
            // 
            // button6
            // 
            button6.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button6.Location = new Point(0, 438);
            button6.Name = "button6";
            button6.Size = new Size(222, 56);
            button6.TabIndex = 7;
            button6.Text = "Nhà Cung Cấp";
            button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button5.Location = new Point(0, 382);
            button5.Name = "button5";
            button5.Size = new Size(222, 56);
            button5.TabIndex = 6;
            button5.Text = "Nhập Hàng";
            button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button4.Location = new Point(0, 326);
            button4.Name = "button4";
            button4.Size = new Size(222, 56);
            button4.TabIndex = 5;
            button4.Text = "Tạo Hóa Đơn";
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button3.Location = new Point(0, 270);
            button3.Name = "button3";
            button3.Size = new Size(222, 56);
            button3.TabIndex = 4;
            button3.Text = "Quản Lý Sản Phẩm";
            button3.UseVisualStyleBackColor = true;
            // 
            // btnQuanLyKhachHangMenu
            // 
            btnQuanLyKhachHangMenu.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnQuanLyKhachHangMenu.Location = new Point(0, 214);
            btnQuanLyKhachHangMenu.Name = "btnQuanLyKhachHangMenu";
            btnQuanLyKhachHangMenu.Size = new Size(222, 56);
            btnQuanLyKhachHangMenu.TabIndex = 3;
            btnQuanLyKhachHangMenu.Text = "Quản Lý Khách Hàng";
            btnQuanLyKhachHangMenu.UseVisualStyleBackColor = true;
            btnQuanLyKhachHangMenu.Click += btnQuanLyKhachHangMenu_Click;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button1.Location = new Point(0, 158);
            button1.Name = "button1";
            button1.Size = new Size(222, 56);
            button1.TabIndex = 2;
            button1.Text = "Trang Chủ";
            button1.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            panel3.Controls.Add(pictureBox1);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(222, 158);
            panel3.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(222, 154);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1036, 503);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Chào mừng bạn làm việc ";
            panel1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panelShow.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private PictureBox pictureBox1;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button btnQuanLyKhachHangMenu;
        private Button button1;
        private Button button6;
        private Panel panel5;
        private Button btnSuppliers;
        private Button btnOrders;
        private Button btnInvoices;
        private Button btnProduct;
        private Button btnCustomers;
        private Label label2;
        private Panel panelShow;
        private Panel panel6;
        private Panel panel4;
        private Label label1;
    }
}