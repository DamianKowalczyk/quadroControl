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
            Byte[] t = {1}; // send start command
            theReferenceUsbDevice.send(t);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void offset1TrackBar_Scroll(object sender, EventArgs e)
        {
            //Byte[] t = ascii.GetBytes(dataForSendingTxtBox.Text);
            //theReferenceUsbDevice.send(t);
            offset1TextBox.Text = offset1TrackBar.Value.ToString()+ ",00%"; //display value into appriopriate textBox
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            Byte[] t = {2}; // send safeOff command
            theReferenceUsbDevice.send(t);
        }
                
        private void offset2TrackBar_Scroll(object sender, EventArgs e)
        {            
            String val = offset2TrackBar.Value.ToString();
            Byte[] tabVal = normalizeValue(val);
            //sentDataTextBox.Text = tabVal[0].ToString();
            offset2TextBox.Text = offset2TrackBar.Value.ToString() + ",00%"; //display value into appriopriate textBox
        }

        private void offset3TrackBar_Scroll(object sender, EventArgs e)
        {
            
            offset3TextBox.Text = offset3TrackBar.Value.ToString() + ",00%"; //display value into appriopriate textBox
        }

        private void offset4TrackBar_Scroll(object sender, EventArgs e)
        {
           
            offset4TextBox.Text = offset4TrackBar.Value.ToString() + ",00%"; //display value into appriopriate textBox
        }

        private void setPowerTrackBar_Scroll(object sender, EventArgs e)
        {
            powerTextBox.Text = setPowerTrackBar.Value.ToString() + ",00%";
        }

        private Byte[] normalizeValue(String value)
        { 
            UInt16 tmpVal = Convert.ToUInt16(value);
            tmpVal *= 25;   // 100 should give 2500 of ..

            byte[] tabVal = new byte[2];
            tabVal[0] = (byte) (tmpVal / 256);
            tabVal[1] = (byte) (tmpVal & 255u);            
            
            return tabVal;
        }

        private void sendValuesFromOffsetTrackBars() 
        {
            
            

                       
        }



        
    }
}
