using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project
{
    public partial class frmStock : Form
    {
        public frmStock()
        {
            InitializeComponent();
        }

        private void frmStock_Load(object sender, EventArgs e)
        {
            // Initialize the DataGridView with columns
            DataGridView.Columns.Add("Code", "Code");
            DataGridView.Columns.Add("Name", "Name");
            DataGridView.Columns.Add("Supplier", "Supplier");
            DataGridView.Columns.Add("Category", "Category");
            DataGridView.Columns.Add("Price", "Price");
            DataGridView.Columns.Add("Quantity", "Quantity");

            DataGridViewButtonColumn removeButton = new DataGridViewButtonColumn();
            removeButton.Name = "Remove";
            removeButton.Text = "Remove";
            removeButton.UseColumnTextForButtonValue = true;
            DataGridView.Columns.Add(removeButton);

            DataGridViewButtonColumn restockButton = new DataGridViewButtonColumn();
            restockButton.Name = "Restock";
            restockButton.Text = "Restock";
            restockButton.UseColumnTextForButtonValue = true;
            DataGridView.Columns.Add(restockButton);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Add data to the DataGridView
            DataGridView.Rows.Add(txtCode.Text, txtName.Text, txtSupplier.Text, txtCategory.Text, txtPrice.Text, txtQuantity.Text);

            // Clear the text boxes
            txtCode.Clear();
            txtName.Clear();
            txtSupplier.Clear();
            txtCategory.Clear();
            txtPrice.Clear();
            txtQuantity.Clear();
        }

        private void DataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if the clicked cell is a button cell
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == DataGridView.Columns["Remove"].Index)
                {
                    // Remove the selected row
                    DataGridView.Rows.RemoveAt(e.RowIndex);
                }
                else if (e.ColumnIndex == DataGridView.Columns["Restock"].Index)
                {
                    // Restock the selected item
                    int quantity = Convert.ToInt32(DataGridView.Rows[e.RowIndex].Cells["Quantity"].Value);
                    DataGridView.Rows[e.RowIndex].Cells["Quantity"].Value = quantity + 1000;
                }
            }
        }
    }
}