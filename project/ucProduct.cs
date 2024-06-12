using System;
using System.Drawing;
using System.Windows.Forms;

namespace project
{
    public partial class ucProduct : UserControl
    {
        public ucProduct()
        {
            InitializeComponent();
        }

        public event EventHandler onSelect = null;

        public int Id { get; set; }

        public int Price { get; set; }

        public int Category { get; set; }

        public string PName
        {
            get { return label1.Text; }
            set { label1.Text = value; }
        }

        public Image PImage
        {
            get { return pictureBox1.Image; }
            set { pictureBox1.Image = value; }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            onSelect?.Invoke(this, EventArgs.Empty);
        }

        private void guna2ShadowPanel1_Paint(object sender, PaintEventArgs e)
        {
            
        }
    }
}