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

/// using DarrenLee.Bluetooth;


namespace BLE
{
    public partial class Form1 : Form
    {
        Bluetooth_Server blueServer = new Bluetooth_Server();
        public Form1()
        {
            InitializeComponent();

            stxtStatus.Text = "Not doing anything ";
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            stxtStatus.Text = "Waiting for clients ...";
            blueServer.Start();
            blueServer.IsConnected += BlueServer_IsConnected;
            blueServer.DataReceived += BlueServer_DataReceived;


        }

        private void BlueServer_IsConnected(object? sender, EventArgs e)

        {
            MessageBox.Show(" Bluetooth connection established! ");

            if(InvokeRequired) 
            {
                this.Invoke(new Action(() =>
                {
                    stxtStatus.Text = " Connected";
                }));
            }
        }

        private void BlueServer_DataReceived(object? sender, BluetoothServerEventArgs e)
        {
            if (InvokeRequired)
            {
                this.Invoke(new Action(() =>
                {
                    stxtMessageBox.AppendText(e.Message + Environment.NewLine);
                }));
            }
        }
    }


    }