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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLoggaIn_Click(object sender, EventArgs e)
        {
            MySqlConnection connection;

            string connectionString =
               "SERVER=5.178.75.122;DATABASE=webshopdb;UID=edvin;PASSWORD=EdvinT;";

            connection = new MySqlConnection(connectionString);
            connection.Open();

            kunder aktuellKund = null;

            try
            {
                MySqlCommand cmd = kunder.getKunderByUsername(tbxUsername.Text);

                MySqlDataAdapter datAdapt = new MySqlDataAdapter();
                datAdapt.SelectCommand = cmd;
                cmd.Connection = connection;
                DataTable dt = new DataTable();
                datAdapt.Fill(dt);
                
                //if (dt.Rows.Count > 0)
                aktuellKund = new kunder(dt.Rows[0]);
            }
            catch (Exception error)
            {
                MessageBox.Show("Användarnamnet finns inte!", Text);
                Console.WriteLine(error);
                return;
            }

            connection.Close();

            int id = aktuellKund.ID;
            string namn = aktuellKund.Fornamn + " " + aktuellKund.Efternamn;

            if (aktuellKund == null)
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
                    if (aktuellKund.Anvandarnamn != "admin")
                    {
                        Main main = new Main(id, namn);
                        main.Show();
                        this.Hide();
                    }
                    else
                    {
                        Admin admin = new Admin();
                        admin.Show();
                        this.Hide();
                    }
                }
            }
        }

        private void btnRegistrera_Click(object sender, EventArgs e)
        {
            Registrera registrera = new Registrera();
            registrera.Show();
        }
    }
}
