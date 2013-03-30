using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace quadroControl
{
    public partial class Form1 : Form
    {
        private usbReferenceDevice theReferenceUsbDevice;
        private ASCIIEncoding ascii = new ASCIIEncoding();

        public Form1()
        {
            InitializeComponent();

            theReferenceUsbDevice = new usbReferenceDevice(0xC1CA, 0x0003);
            //theReferenceUsbDevice.usbEvent += new usbReferenceDevice.usbEventsHandler(usbEvent_receiver);
            theReferenceUsbDevice.findTargetDevice();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            /*ASCIIEncoding ascii = new ASCIIEncoding();
            Byte[] chars = new Byte[33];
            chars[0] = 0;
             */ 

            Byte[] t = ascii.GetBytes(dataForSendingTxtBox.Text);

            /*int i;
            for (i = 0; i < Math.Min(t.Length, 32); i++)
                chars[i + 1] = t[i]; 
            theReferenceUsbDevice.send(chars); */

            theReferenceUsbDevice.send(t);
        }

        private void startButton_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
