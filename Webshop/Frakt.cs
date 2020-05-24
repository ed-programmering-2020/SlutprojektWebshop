using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace Webshop
{
    public partial class Frakt : Form
    {
        TcpClient tcpClient = new TcpClient();
        int port = 12345;

        string bestID;

        public Frakt(string item)
        {
            InitializeComponent();
            tcpClient.NoDelay = true;
            bestID = item;
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (!tcpClient.Connected)
            {
                StartConnection();
                MessageBox.Show("Connected to server");
            }
        }

        public async void StartConnection()
        {
            try
            {
                IPAddress address = IPAddress.Parse(tbxIPAddress.Text);
                await tcpClient.ConnectAsync(address, port);
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, Text);
                return;
            }

            btnConnect.Enabled = false;
        }

        private void btnSendInfo_Click(object sender, EventArgs e)
        {
            StartTransmission(bestID);
        }

        public async void StartTransmission(string input)
        {
            byte[] output = Encoding.Unicode.GetBytes(input);

            try
            {
                await tcpClient.GetStream().WriteAsync(output, 0, output.Length);
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, Text);
                return;
            }
        }
    }
}
