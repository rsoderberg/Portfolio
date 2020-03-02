using System;
using System.IO.Ports;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace RoomTemp
{
    public partial class Form1 : Form
    {
        SynchronizationContext ctx = null;
        SerialPort port = new SerialPort("COM3", 9600);

        public Form1()
        {
            InitializeComponent();

            port.DataReceived += Port_DataReceived;
            port.DtrEnable = true;

            ctx = SynchronizationContext.Current;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            port.Open();
        }

        private void printTemp(object data)
        {
            float[] tempData = data as float[];

            try
            {
                if (tempData[0] > 0 && tempData[0] < 150)
                {
                    //tempLabel.Text = " ";
                    tempLabel.Text = "72";
                }
            }
            catch { }
        }

        private void Port_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            string data = port.ReadLine();

            try
            {
                // Receive data from device
                float[] temp = data.Trim().Split(',').Select(float.Parse).ToArray();

                ctx.Post(printTemp, temp);
            }
            catch { }
        }
    }
}
