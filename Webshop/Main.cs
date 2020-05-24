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
    public partial class Main : Form
    {
        int ID;
        bool objectSelected = false;
        string selectedItem;

        public Main(int item, String item1)
        {
            InitializeComponent();
            lblUsername.Text = item1;
            lblKundID.Text += item;
            ID = item;

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void btnNyBestallning_Click(object sender, EventArgs e)
        {
            NyBest nyBest = new NyBest(ID);
            nyBest.ShowDialog();
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnÄndraBestallning_Click(object sender, EventArgs e)
        {
            if (objectSelected == true)
            {
                AndraBest andraBest = new AndraBest(selectedItem);
                andraBest.ShowDialog();
            }
            else
            {
                MessageBox.Show("Välj beställning att ändra!");
            }
        }

        private void btnMinaBestallningar_Click(object sender, EventArgs e)
        {
            objectSelected = false;

            MySqlConnection connection;

            string connectionString =
               "SERVER=5.178.75.122;DATABASE=webshopdb;UID=edvin;PASSWORD=EdvinT;";

            connection = new MySqlConnection(connectionString);
            connection.Open();

            MySqlDataReader dataReader = null;

            MySqlCommand mySqlCommand = bestallningar.getAllWithID(ID);

            mySqlCommand.Connection = connection;
            dataReader = mySqlCommand.ExecuteReader();

            lbxBest.Items.Clear();
            tbxBestallningar.Clear();

            while (dataReader.Read())
            {
                string Item = dataReader.GetString(0) + "; Modell: " + dataReader.GetString(2) + "; Märke: " + dataReader.GetString(3);
                lbxBest.Items.Add(Item);
            }

            connection.Close();
        }

        private void lbxBest_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbxBest.SelectedItem != null)
            {
                objectSelected = true;

                MySqlConnection connection;

                string connectionString =
                   "SERVER=5.178.75.122;DATABASE=webshopdb;UID=edvin;PASSWORD=EdvinT;";

                connection = new MySqlConnection(connectionString);
                connection.Open();

                MySqlDataReader dataReader = null;

                string BestSats;
                BestSats = lbxBest.SelectedItem.ToString();
                string stringAfterBeforeChar = BestSats.Substring(0, BestSats.IndexOf(";"));

                selectedItem = stringAfterBeforeChar;

                MySqlCommand mySqlCommand = bestallningar.getAllWithBestID(stringAfterBeforeChar);

                mySqlCommand.Connection = connection;
                dataReader = mySqlCommand.ExecuteReader();

                while (dataReader.Read())
                {
                    tbxBestallningar.Clear();
                    for (int i = 0; i < dataReader.FieldCount; i++)
                    {
                        tbxBestallningar.AppendText(dataReader.GetName(i) + ": " + dataReader.GetValue(i) + "\r\n");
                    }
                }

                connection.Close();
            }
        }

        private void btnCheckShipping_Click(object sender, EventArgs e)
        {
            if (objectSelected == true)
            {
                Frakt frakt = new Frakt(selectedItem);
                frakt.ShowDialog();
            }
            else
            {
                MessageBox.Show("Välj beställning att kolla frakt på!");
            }
        }
    }
}
