namespace QuanLyCuaHang
{
    partial class CustomersForm
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
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            dataGridView1 = new DataGridView();
            btnDanhSachKhachHang = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtName = new TextBox();
            txtPhone = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnThem
            // 
            btnThem.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnThem.Location = new Point(410, 98);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(150, 51);
            btnThem.TabIndex = 0;
            btnThem.Text = "Thêm khách hàng";
            btnThem.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            btnSua.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSua.Location = new Point(566, 98);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(150, 51);
            btnSua.TabIndex = 1;
            btnSua.Text = "Sửa thông tin ";
            btnSua.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            btnXoa.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnXoa.Location = new Point(722, 98);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(150, 51);
            btnXoa.TabIndex = 2;
            btnXoa.Text = "Xóa khách hàng";
            btnXoa.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(1, 201);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(881, 217);
            dataGridView1.TabIndex = 3;
            // 
            // btnDanhSachKhachHang
            // 
            btnDanhSachKhachHang.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnDanhSachKhachHang.Location = new Point(617, 26);
            btnDanhSachKhachHang.Name = "btnDanhSachKhachHang";
            btnDanhSachKhachHang.Size = new Size(255, 51);
            btnDanhSachKhachHang.TabIndex = 4;
            btnDanhSachKhachHang.Text = "Danh sách khách hàng";
            btnDanhSachKhachHang.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 26);
            label1.Name = "label1";
            label1.Size = new Size(65, 20);
            label1.TabIndex = 5;
            label1.Text = "Họ tên : ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 72);
            label2.Name = "label2";
            label2.Size = new Size(108, 20);
            label2.TabIndex = 6;
            label2.Text = "Số điện thoại : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 113);
            label3.Name = "label3";
            label3.Size = new Size(97, 20);
            label3.TabIndex = 7;
            label3.Text = "Ngày tháng : ";
            // 
            // txtName
            // 
            txtName.Location = new Point(107, 19);
            txtName.Name = "txtName";
            txtName.Size = new Size(265, 27);
            txtName.TabIndex = 8;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(140, 69);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(232, 27);
            txtPhone.TabIndex = 9;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(123, 108);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(249, 27);
            dateTimePicker1.TabIndex = 10;
            // 
            // CustomersForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCyan;
            ClientSize = new Size(884, 418);
            Controls.Add(dateTimePicker1);
            Controls.Add(txtPhone);
            Controls.Add(txtName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnDanhSachKhachHang);
            Controls.Add(dataGridView1);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Name = "CustomersForm";
            Text = "CustomersForm";
            Load += CustomersForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
        private DataGridView dataGridView1;
        private Button btnDanhSachKhachHang;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtName;
        private TextBox txtPhone;
        private DateTimePicker dateTimePicker1;
    }
}