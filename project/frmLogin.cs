using System;
using System.Drawing; // Include this namespace for the Size class
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using project; // Assuming this is where your UserControls are defined

namespace sysytem
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            btnCombo.Items.Add("Dealer");
            btnCombo.Items.Add("Staff");
            btnCombo.Items.Add("Manager");
            btnCombo.SelectedIndex = 0;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string mysqlconn = "server=localhost;port=3306;user=root;database=login;password=";
            using (MySqlConnection MySqlConnection = new MySqlConnection(mysqlconn))
            {
                string username = txtUser.Text.ToString();
                string password = txtPass.Text.ToString();
                string role = btnCombo.SelectedItem?.ToString();

                if (String.IsNullOrEmpty(username) || String.IsNullOrEmpty(password))
                {
                    MessageBox.Show("Username or password cannot be empty. Please try again.");
                    return;
                }

                try
                {
                    MySqlConnection.Open();
                    string query = "SELECT * FROM user WHERE username=@username AND password=@password";
                    using (MySqlCommand MySqlCommand = new MySqlCommand(query, MySqlConnection))
                    {
                        MySqlCommand.Parameters.AddWithValue("@username", username);
                        MySqlCommand.Parameters.AddWithValue("@password", password);

                        using (MySqlDataReader reader = MySqlCommand.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Hide();

                                Form mainForm = new Form();
                                UserControl control = null;

                                switch (role)
                                {
                                    case "Dealer":
                                        control = new CategoryControl();
                                        break;
                                    case "Staff":
                                        control = new staffControl();
                                        break;
                                    case "Manager":
                                        control = new mControl();
                                        break;
                                }

                                if (control != null)
                                {
                                    control.Dock = DockStyle.Fill;
                                    mainForm.Controls.Add(control);
                                    mainForm.ClientSize = control.Size; // Set the form size to match the UserControl size
                                    mainForm.StartPosition = FormStartPosition.CenterScreen;
                                    mainForm.ShowDialog();
                                }

                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("Invalid username or password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    MySqlConnection.Close();
                }
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            // Any initialization code can go here
        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Handle combo box selection change if needed
        }
    }
}