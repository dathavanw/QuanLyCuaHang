using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace QuanLyCuaHang
{
    using System.Data;
    using System.Data.SqlClient;
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void DisplayFormInPanel(Form childForm)
        {
            // Đặt Form con vào trong Panel
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            // Xóa các điều khiển cũ trong Panel (nếu có)
            //  panelShow.Controls.Clear();

            // Thêm Form con vào Panel
            panel6.Controls.Add(childForm);
            panel6.Tag = childForm;

            // Hiển thị Form con
            childForm.BringToFront();
            childForm.Show();
        }


        private void btnQuanLyKhachHangMenu_Click(object sender, EventArgs e)
        {
            this.btnInvoices.Hide();
            this.btnCustomers.Hide();
            this.btnOrders.Hide();
            this.btnProduct.Hide();
            this.btnSuppliers.Hide();
            CustomersForm customersForm = new CustomersForm();
            DisplayFormInPanel(customersForm);
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {

        }
    }
}
