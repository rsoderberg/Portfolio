using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

// Analog LED Clock using Circuit Playground
// Integrated with a C# .NET Windows Form Application

// Rachel Soderberg
// October 2018

namespace Analog_LED_Clock
{
    public partial class Form1 : Form
    {
        SynchronizationContext ctx = null;
        SerialPort port = new SerialPort("COM7", 9600);

        public Form1()
        {
            InitializeComponent();

            port.DataReceived += Port_DataReceived;
            port.DtrEnable = true;

            ctx = SynchronizationContext.Current;
        }

        // Receive data from device
        private void Port_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            string data = port.ReadLine();

            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            port.Open();
        }
    }
}
