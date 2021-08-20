using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO.Ports;
using System.Windows.Forms;
using System.Threading;

namespace Team_7_KUKA_arm
{
    public partial class Comports : Form
    {
        public Comports()
        {
            InitializeComponent();

            // Initialize Ports and imports them into the listbox
            foreach (String item in SerialPort.GetPortNames())
            {
                cbxPorts.Items.Add(item);
            }
        }

        SerialPort serialPort;

        public void serialportConnect(String port, int baudrate, Parity parity, int databits, StopBits stopbits)
        {
            DateTime dt = DateTime.Now;
            String dtn = dt.ToShortTimeString();

            serialPort = new SerialPort(port, baudrate, parity, databits, stopbits);
            try
            {
                serialPort.Open();
                rtbOutput.Text += "[" + dtn + "] " + "Connected\n";
                serialPort.DataReceived += new SerialDataReceivedEventHandler(DataReceived);
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString(), "Error"); }
        }

        private void DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            DateTime dt = DateTime.Now;
            String dtn = dt.ToShortTimeString();

            rtbOutput.AppendText("[" + dtn + "] " + "Received: " + serialPort.ReadExisting() + "\n");
        }

        private void btnGetPorts_Click(object sender, EventArgs e)
        {
            String port = cbxPorts.Text;
            int baudrate = Convert.ToInt32(cbxBaudRate.Text);
            Parity parity = (Parity)Enum.Parse(typeof(Parity), cbxParity.Text);
            int databits = Convert.ToInt32(cbxDataBits.Text);
            StopBits stopbits = (StopBits)Enum.Parse(typeof(StopBits), cbxStopBits.Text);

            serialportConnect(port, baudrate, parity, databits, stopbits);
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            String dtn = dt.ToShortTimeString();
            String data = txtInput.Text;
            serialPort.Write(data);
            rtbOutput.AppendText("[" + dtn + "] " + "Sent: " + data + "\n");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            String dtn = dt.ToShortTimeString();

            if (serialPort.IsOpen)
            {
                serialPort.Close();
                rtbOutput.Text += "[" + dtn + "] " + "Disconnected\n";
            }
        }
    }
}
