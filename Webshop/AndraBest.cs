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
    public partial class AndraBest : Form
    {
        string bestID;

        public AndraBest(string item)
        {
            InitializeComponent();

            bestID = item;

            MySqlConnection connection;

            string connectionString =
               "SERVER=5.178.75.122;DATABASE=webshopdb;UID=edvin;PASSWORD=EdvinT;";

            connection = new MySqlConnection(connectionString);
            connection.Open();

            MySqlDataReader dataReader = null;

            MySqlCommand mySqlCommand = bestallningar.getAllWithBestID(bestID);

            mySqlCommand.Connection = connection;
            dataReader = mySqlCommand.ExecuteReader();

            while (dataReader.Read())
            {
                cbxModel.Text = dataReader.GetValue(2).ToString();
                cbxBrand.Text = dataReader.GetValue(3).ToString();
                cbxPatterns.Text = dataReader.GetValue(4).ToString();
                cbxColors.Text = dataReader.GetValue(5).ToString();
            }

            connection.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnRadera_Click(object sender, EventArgs e)
        {
            MySqlConnection connection;

            string connectionString =
               "SERVER=5.178.75.122;DATABASE=webshopdb;UID=edvin;PASSWORD=EdvinT;";

            connection = new MySqlConnection(connectionString);
            connection.Open();

            MySqlCommand mySqlCommand = bestallningar.DeleteWithBestID(bestID);

            mySqlCommand.Connection = connection;
            mySqlCommand.ExecuteNonQuery();

            connection.Close();

            MessageBox.Show("Beställning har raderats!");
            this.Close();
        }

        private void btnSpara_Click(object sender, EventArgs e)
        {
            MySqlConnection connection;

            string connectionString =
               "SERVER=5.178.75.122;DATABASE=webshopdb;UID=edvin;PASSWORD=EdvinT;";

            connection = new MySqlConnection(connectionString);
            connection.Open();

            MySqlCommand mySqlCommand = bestallningar.UppdateWithBestID(bestID, cbxModel.Text, cbxBrand.Text, cbxPatterns.Text, cbxColors.Text);

            mySqlCommand.Connection = connection;
            mySqlCommand.ExecuteNonQuery();

            connection.Close();

            MessageBox.Show("Beställning har ändrats!");
            this.Close();
        }
    }
}
