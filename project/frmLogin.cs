using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace project
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            // Perform any initialization or setup here
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            // This event handler can be removed if not used
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Simulate a successful login
            MessageBox.Show("Login successful!");
            frmCategory categoryForm = new frmCategory();
            categoryForm.Show();
            this.Hide(); // Hide the login form
        }
    }
}