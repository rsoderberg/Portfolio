// Guitar Tuner Using Circuit Playground
// Integrated with a C# Windows Form

// Rachel Soderberg
// June 2017

// Std Guitar Frequencies
// ----------------------
// 1 (e)   329.63 Hz   E4
// 2 (B)   246.94 Hz   B3
// 3 (G)   196.00 Hz   G3
// 4 (D)   146.83 Hz   D3
// 5 (A)   110.00 Hz   A2
// 6 (E)   82.41 Hz    E2


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RSoderbergFinalProject
{
    public partial class Form1 : Form
    {
        SynchronizationContext ctx = null;
        SerialPort port = new SerialPort("COM4", 9600);

        public Form1()
        {
            InitializeComponent();

            port.DataReceived += Port_DataReceived;
            port.DtrEnable = true;

            ctx = SynchronizationContext.Current;
        }

        public class SoundEventArgs : EventArgs
        {
            public float frequency { get; set; }
        }

        // Print current frequency to keyLabel to display the key
        // the user is attempting to tune. If key cannot be determined,
        // "?" will be displayed.

        //Note: Ranges are not true to the ideal ranges, expanded for a cleaner display
        void printKey(object data)
        {
            float[] soundData = data as float[];

            try
            {
                // Convert each frequency to its letter for display
                if (soundData[0] >= 72 && soundData[0] <= 96)
                {
                    keyLabel.Text = " ";
                    keyLabel.Text = soundData[0].ToString(" E ");
                }

                if (soundData[0] >= 97 && soundData[0] <= 128)
                {
                    keyLabel.Text = " ";
                    keyLabel.Text = soundData[0].ToString(" A ");
                }

                if (soundData[0] >= 129 && soundData[0] <= 172)
                {
                    keyLabel.Text = " ";
                    keyLabel.Text = soundData[0].ToString(" D ");
                }

                if (soundData[0] >= 173 && soundData[0] <= 236)
                {
                    keyLabel.Text = " ";
                    keyLabel.Text = soundData[0].ToString(" G ");
                }

                if (soundData[0] >= 237 && soundData[0] <= 289)
                {
                    keyLabel.Text = " ";
                    keyLabel.Text = soundData[0].ToString(" B ");
                }

                if (soundData[0] >= 290 && soundData[0] <= 340)
                {
                    keyLabel.Text = " ";
                    keyLabel.Text = soundData[0].ToString(" e ");
                }

                // Current frequency is not within normal range
                if (soundData[0] < 72 || soundData[0] > 340)
                {
                    keyLabel.Text = " ";
                    keyLabel.Text = soundData[0].ToString(" ? ");
                }
            }
            catch { }
        }

        // Receive data from device
        private void Port_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            string data = port.ReadLine();

            try
            {
                float[] sound = data.Trim().Split(',').Select(float.Parse).ToArray();

                ctx.Post(printKey, sound);
            }
            catch { }
        }

        private void playNote(int note, int timing)
        {
            if (port.IsOpen)
            {
                byte[] buffer = new byte[5];

                buffer[0] = 0xAA;

                buffer[1] = (byte)(note >> 8);
                buffer[2] = (byte)note;
                buffer[3] = (byte)(timing >> 8);
                buffer[4] = (byte)timing;

                port.Write(buffer, 0, buffer.Length);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            port.Open();
        }

        // Tell Circuit Playground to play e (330)
        private void eButton_Click(object sender, EventArgs e)
        {
            playNote(330, 1000);
        }

        // Tell Circuit Playground to play B (247)
        private void BButton_Click(object sender, EventArgs e)
        {
            playNote(247, 1000);
        }

        // Tell Circuit Playground to play G (196)
        private void GButton_Click(object sender, EventArgs e)
        {
            playNote(196, 1000);
        }

        // Tell Circuit Playground to play D (147)

        private void DButton_Click(object sender, EventArgs e)
        {
            playNote(147, 1000);
        }

        // Tell Circuit Playground to play A (110)
        private void AButton_Click(object sender, EventArgs e)
        {
            playNote(110, 1000);
        }

        // Tell Circuit Playground to play E (82)
        private void bigEButton_Click(object sender, EventArgs e)
        {
            playNote(82, 1000);
        }
    }
}
