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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLoggaIn_Click(object sender, EventArgs e)
        {
            string anvandarnamn = "";
            string id = "";
            string namn = "";
            string losenord = "";

            MySqlConnection connection;

            string connectionString =
               "SERVER=5.178.75.122;DATABASE=webshopdb;UID=edvin;PASSWORD=EdvinT;";

            connection = new MySqlConnection(connectionString);
            connection.Open();

            MySqlCommand cmd = kunder.getKunderByUsername(tbxUsername.Text);
            
            MySqlDataAdapter datAdapt = new MySqlDataAdapter();
            datAdapt.SelectCommand = cmd;
            cmd.Connection = connection;
            DataTable dt = new DataTable();
            datAdapt.Fill(dt);

            kunder aktuellKund = null;
            if (dt.Rows.Count > 0)
            aktuellKund = new kunder(dt.Rows[0]);

            if(aktuellKund == null)
            {
                MessageBox.Show("Det finns inget konto med det användarnamnet!");
            }
            else
            {
                if (aktuellKund.Losenord != tbxPassword.Text)
                {
                    MessageBox.Show("Felaktigt lösenord!");
                }
                else
                {
                    Form2 form2 = new Form2(id, namn);
                    form2.Show();
                    this.Hide();
                }
            }
        }

        private void btnRegistrera_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.Show();
        }
    }
}
