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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void btnRegistrera_Click(object sender, EventArgs e)
        {
            string anvandarnamn = "";

            MySqlConnection connection;

            string connectionString =
               "SERVER=5.178.75.122;DATABASE=webshopdb;" +
               "UID=edvin;PASSWORD=EdvinT;";

            connection = new MySqlConnection(connectionString);
            connection.Open();

            MySqlDataReader dataReader = null;

            MySqlCommand cmd = new MySqlCommand("select Anvandarnamn from kunder", connection);

            dataReader = cmd.ExecuteReader();

            while (dataReader.Read())
            {
                if (tbxAnvandarnamn.Text == dataReader.GetString("Anvandarnamn"))
                {
                    anvandarnamn = dataReader.GetString("Anvandarnamn");
                }
            }

            connection.Close();

            if (anvandarnamn != tbxAnvandarnamn.Text)
            {
                if (tbxLosenord1.Text == tbxLosenord2.Text)
                {
                    connection = new MySqlConnection(connectionString);
                    connection.Open();

                    MySqlCommand cmd1 = new MySqlCommand("Insert into kunder (Fornamn, Efternamn, Anvandarnamn, Losenord) Values (@f, @e, @a, @l)", connection);
                    cmd1.Prepare();
                    cmd1.Parameters.AddWithValue("@f", tbxFornamn.Text);
                    cmd1.Parameters.AddWithValue("@e", tbxEfternamn.Text);
                    cmd1.Parameters.AddWithValue("@a", tbxAnvandarnamn.Text);
                    cmd1.Parameters.AddWithValue("@l", tbxLosenord1.Text);

                    cmd1.ExecuteReader();

                    connection.Close();

                    MessageBox.Show("Nytt konto skapat!");

                    this.Close();
                }
                else
                {
                    MessageBox.Show("Felaktigt lösenords bekräftelse!");
                }
            }
            else
            {
                MessageBox.Show("Användarnamnet finns redan!");
            }
        }
    }
}
