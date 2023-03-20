using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DarrenLee.Bluetooth;
using InTheHand.Net;
using InTheHand.Net.Sockets;





namespace Client
{
    public partial class Form1 : Form
    {
        Bluetooth_Client blueClient = new Bluetooth_Client(" MSI-laptop");
        BluetoothClient client = new BluetoothClient();

        public Form1()
        {
            InitializeComponent();

            ctxtStatus.Text = "Not doing anything ";
        }

        private void btnPair_Click(object sender, EventArgs e)
        {
            
            blueClient.Start();

            ctxtStatus.Text = "Trying to connect server ";

            blueClient.IsConnected += BlueClient_IsConnected;
        }

        private void BlueClient_IsConnected(object? sender, EventArgs e)
        {
            MessageBox.Show("Bluetooth connection established !");

            if (InvokeRequired)
            {
                this.Invoke(new Action(() =>
                {
                    ctxtStatus.Text = " Connected";
                }));
            }
        }

        private void cbtnSend_Click(object sender, EventArgs e)
        {
            blueClient.SyncMessage(ctxtMessageBox.Text);
            ctxtMessageBox.Text = null;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            lboxAvailabe.Items.Clear();
            BluetoothDeviceInfo[] devices = client.DiscoverDevices();
            foreach (BluetoothDeviceInfo d in devices)
            {
                lboxAvailabe.Items.Add(d.DeviceName);
            }

        }
    }
}