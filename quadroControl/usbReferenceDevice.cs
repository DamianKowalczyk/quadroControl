using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using usbGenericHidCommunications;

namespace quadroControl
{
    class usbReferenceDevice : usbGenericHidCommunication
    {
        public usbReferenceDevice(int vid, int pid)
            : base(vid, pid) { }

        public bool led(char led_id)
        {
            Byte[] outputBuffer = new Byte[33];
            //Byte[] inputBuffer = new Byte[2];
            outputBuffer[0] = 0; // Byte 0 must be set to 0
            outputBuffer[1] = (byte)led_id;
            bool success = writeRawReportToDevice(outputBuffer);
            return success;
        }

        public bool leds(char leds_id)
        {
            Byte[] outputBuffer = new Byte[33];
            outputBuffer[0] = 0;
            outputBuffer[2] = (byte)leds_id;
            bool success = writeRawReportToDevice(outputBuffer);
            return success;
        }

        public bool send(Byte[] data)
        {
            bool success = writeRawReportToDevice(data);
            return success;
        }

        ASCIIEncoding ascii = new ASCIIEncoding();
        Byte[] chars;

        public bool rf_cmd(byte cmd)
        {
            Byte[] outputBuffer = new Byte[33];
            outputBuffer[0] = 0; // Byte 0 must be set to 0
            outputBuffer[1] = cmd;
            outputBuffer[2] = (byte)(2);
            outputBuffer[3] = (byte)(3);
            outputBuffer[4] = (byte)(4);
            outputBuffer[5] = (byte)(5);
            outputBuffer[6] = (byte)(6);
            outputBuffer[7] = (byte)(7);
            outputBuffer[8] = (byte)(8);
            outputBuffer[9] = (byte)(9);
            outputBuffer[10] = 13;
            outputBuffer[11] = 10;
            chars = ascii.GetBytes("test");
            if (chars.Length >= 4)
            {
                outputBuffer[12] = chars[0];
                outputBuffer[13] = chars[1];
                outputBuffer[14] = chars[2];
                outputBuffer[15] = chars[3];
            }
            else { }
            bool success = writeRawReportToDevice(outputBuffer);
            return success;
        }

        public bool raw_read(out Byte[] data)
        {
            data = new Byte[33];
            bool success = readSingleReportFromDevice(ref data);
            return success;
        }
    }
}
