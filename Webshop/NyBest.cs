using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Webshop
{
    public partial class NyBest : Form
    {
        int kundID;

        public NyBest(int item)
        {
            InitializeComponent();
            kundID = item;
        }

        private void cbxModel_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSparaKöp_Click(object sender, EventArgs e)
        {
            bestallningar bestall = new bestallningar();
            bestall.kundID = kundID;
            bestall.Model = cbxModel.Text;
            bestall.Marke = cbxBrand.Text;
            bestall.Monster = cbxPatterns.Text;
            bestall.Farg = cbxColors.Text;

            MySqlConnection connection;

            string connectionString =
               "SERVER=5.178.75.122;DATABASE=webshopdb;UID=edvin;PASSWORD=EdvinT;";

            connection = new MySqlConnection(connectionString);
            connection.Open();

            MySqlCommand command = bestallningar.GetInsertCommandAutoID(kundID, cbxModel.Text, cbxBrand.Text, cbxPatterns.Text, cbxColors.Text);

            command.Connection = connection;
            command.ExecuteReader();

            connection.Close();

            MessageBox.Show("Ny beställning har registrerats!");
            this.Close();
        }
    }
}
