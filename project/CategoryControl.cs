using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace project
{
    public partial class CategoryControl : UserControl
    {
        private SqlConnection connection;
        private DataTable dt;

        public CategoryControl()
        {
            InitializeComponent();
            InitializeDatabaseConnection();
        }

        private void InitializeDatabaseConnection()
        {
            // Initialize the database connection
            string connectionString = "your_connection_string_here"; // Replace with your actual connection string
            connection = new SqlConnection(connectionString);
        }

        private void CategoryControl_Load(object sender, EventArgs e)
        {
            LoadCategories();
        }

        private void btnOrderStatus_Click(object sender, EventArgs e)
        {
            frmOrderStatus fOS = new frmOrderStatus();
            fOS.ShowDialog();
        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            frmStock fOS = new frmStock();
            fOS.ShowDialog();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddCategory();
        }

        private void LoadCategories()
        {
            try
            {
                string query = "SELECT * FROM Category";
                SqlDataAdapter da = new SqlDataAdapter(query, connection);
                dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading categories: " + ex.Message);
            }
        }

        private void AddCategory()
        {
            try
            {
                string query = "INSERT INTO Category (CategoryName) VALUES (@CategoryName)";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@CategoryName", "New Category"); // Replace with actual category name

                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();

                LoadCategories(); // Refresh the data grid view
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding category: " + ex.Message);
            }
        }
    }
}