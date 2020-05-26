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
        TcpListener tcpListener;
        int port = 12345;

        string bestID;
        string fraktTid;

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
            }
        }

        public async void StartConnection()
        {
            try
            {
                IPAddress address = IPAddress.Parse(tbxIPAddress.Text);
                port = 12345;
                await tcpClient.ConnectAsync(address, port);
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, Text);
                return;
            }

            btnConnect.Enabled = false;
            btnSendInfo.Enabled = true;
            MessageBox.Show("Connected to server");
        }

        private void btnSendInfo_Click(object sender, EventArgs e)
        {
            StartTransmission(bestID);
            if (tcpClient.Connected)
            {
                btnSendInfo.Enabled = false;
            }

            try
            {
                port = 12346;
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

            fraktTid = Encoding.Unicode.GetString(buffert, 0, e);

            tbxFraktInfo.Text = "Din beställning kommer att anlända till närmsta postombud inom " + fraktTid + " timmar.";
        }
    }
}
