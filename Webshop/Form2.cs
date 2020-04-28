using System;
using System.Windows.Forms;

namespace Webshop
{
    public partial class Form2 : Form
    {
        public Form2(String Item)
        {
            InitializeComponent();
            lblUsername.Text = Item;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void btnNyBestallning_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.ShowDialog();
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
