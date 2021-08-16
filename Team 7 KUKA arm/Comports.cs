using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO.Ports;
using System.Windows.Forms;

namespace Team_7_KUKA_arm
{
    public partial class Comports : Form
    {
        public Comports()
        {
            InitializeComponent();
        }

        private void btnGetPorts_Click(object sender, EventArgs e)
        {
            string[] arrayComPortsNames = SerialPort.GetPortNames();

            foreach (string port in arrayComPortsNames)
            {
                rtbSerialPorts.Text += $"{port} \n";
                cbxPorts.Items.Add(port);
            }
        }
    }
}
