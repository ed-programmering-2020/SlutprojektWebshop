﻿using System;
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
               "SERVER=5.178.75.122;DATABASE=webshopdb;" +
               "UID=edvin;PASSWORD=EdvinT;";

            connection = new MySqlConnection(connectionString);
            connection.Open();

            MySqlDataReader dataReader = null;

            MySqlCommand cmd = new MySqlCommand("select Anvandarnamn from kunder", connection);

            dataReader = cmd.ExecuteReader();

            while (dataReader.Read())
            {
                if (tbxUsername.Text == dataReader.GetString("Anvandarnamn"))
                {
                    anvandarnamn = dataReader.GetString("Anvandarnamn");
                }
            }

            connection.Close();

            connection = new MySqlConnection(connectionString);
            connection.Open();

            MySqlCommand cmd1 = new MySqlCommand("select ID, Fornamn, Efternamn, Losenord from kunder where Anvandarnamn = \"" + anvandarnamn + "\"", connection);

            dataReader = cmd1.ExecuteReader();

            while (dataReader.Read())
            {
                id = dataReader.GetString("ID");
                namn = dataReader.GetString("Fornamn") + " " + dataReader.GetString("Efternamn");
                losenord = dataReader.GetString("Losenord");
            }

            connection.Close();

            if (anvandarnamn == tbxUsername.Text)
            {
                if (tbxPassword.Text == losenord)
                {
                    Form2 form2 = new Form2(id, namn);
                    form2.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Felaktigt lösenord!");
                }
            }
            else
            {
                MessageBox.Show("Det finns inget konto med det användarnamnet!");
            }
        }

        private void btnRegistrera_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.Show();
        }
    }
}
