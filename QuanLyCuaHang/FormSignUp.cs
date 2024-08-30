namespace QuanLyCuaHang
{
    public partial class FormSignUp : Form
    {
        public FormSignUp()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            string userName = txtUserName.Text;
            string password = txtPassword.Text;
            if (userName == "admin" && password == "admin")
            {
                MainForm mainForm = new MainForm();
                this.Hide();
                mainForm.Show();
            }
            else
            {
                MessageBox.Show("Thông tin đăng nhập chưa chính xác","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
