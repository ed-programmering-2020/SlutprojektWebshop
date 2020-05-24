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
using System.IO;
using System.Net;
using System.Net.Sockets;

namespace Webshop
{
    public partial class Admin : Form
    {
        TcpListener tcpListener;
        int port = 12345;

        IPEndPoint iPEndPoint;

        string bestID;

        public Admin()
        {
            InitializeComponent();

            try
            {
                tcpListener = new TcpListener(IPAddress.Any, port);
                tcpListener.Start();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, Text);
                return;
            }

            StartReception();
        }

        private void Admin_Load(object sender, EventArgs e)
        {

        }

        private void Admin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        public async void StartReception()
        {
            TcpClient client;

            try
            {
                client = await tcpListener.AcceptTcpClientAsync();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, Text);
                return;
            }

            StartReading(client);
            StartReception();
        }

        public async void StartReading(TcpClient tcp)
        {
            byte[] buffert = new byte[1024];

            int e = 0;

            try
            {
                e = await tcp.GetStream().ReadAsync(buffert, 0, buffert.Length);
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, Text);
                return;
            }

            bestID = Encoding.Unicode.GetString(buffert, 0, e);

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
                tbxInBestallning.Clear();
                for (int i = 0; i < dataReader.FieldCount; i++)
                {
                    tbxInBestallning.AppendText(dataReader.GetName(i) + ": " + dataReader.GetValue(i) + "\r\n");
                }
            }

            connection.Close();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            
        }
    }
}
