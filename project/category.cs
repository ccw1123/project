using System;
using System.Collections;
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
    public partial class frmCategory : Form
    {
        public frmCategory()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmCategory_Load_1(object sender, EventArgs e)
        {

        }

        private void btnOrderStatus_Click(object sender, EventArgs e)
        {
            frmOrderStatus fOS = new frmOrderStatus();
            fOS.ShowDialog();
        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            frmStock fS = new frmStock();
            fS.ShowDialog();

        }
    }
}