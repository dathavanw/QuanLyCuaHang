namespace QuanLyCuaHang
{
    public partial class Form1 : Form
    {
        public Form1()
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
                MessageBox.Show("Thông tin ðãng nh?p chýa chính xác","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
