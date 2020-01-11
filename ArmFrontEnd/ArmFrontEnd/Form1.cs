using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Threading;

namespace ArmFrontEnd
{
    public partial class Form1 : Form
    {
        private CommandDispatcher commDispatch = new CommandDispatcher();

        public Form1()
        {
            InitializeComponent();
            commDispatch.DataReceived += SerialPort_DataReceived;
        }

        private void sendB_Click(object sender, EventArgs e)
        {
            byte opCode; 
            if(Byte.TryParse(opCodeTB.Text,out opCode)) {
                FormCommand comm = new FormCommand(parametersTB.Text, opCode);
                commDispatch.Dispatch(comm);
            }
            
        }

        private void SerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            var serialPort = commDispatch.SerialPort;
            while (serialPort.BytesToRead > 0)
            {
                string receivedMessage = serialPort.ReadLine();
                if (consoleTB.InvokeRequired)
                {
                    consoleTB.Invoke(new MethodInvoker(delegate { 
                        consoleTB.Text += $"<{DateTime.Now.ToString(CultureInfo.CurrentUICulture.DateTimeFormat.SortableDateTimePattern)}> {receivedMessage}\r\n"; 
                        ScrollToEnd(consoleTB); 
                    }));
                }
                else
                {
                    consoleTB.Text += receivedMessage;
                    ScrollToEnd(consoleTB);
                }
            }
        }

        private void ScrollToEnd(TextBox tb)
        {
            tb.Select(tb.Text.Length - 1, 0);
            tb.ScrollToCaret();
        }

        private void Send_Click(object sender, EventArgs e)
        {
            commDispatch.SerialPort.Write(rawCommandTB.Text);
        }

        private void echoB_Click(object sender, EventArgs e)
        {
            EchoCommand comm = new EchoCommand()
            {
                Message = echoTB.Text
            };
            commDispatch.Dispatch(comm);
        }

        private void servoB_Click(object sender, EventArgs e)
        {
            byte servoNum = Convert.ToByte(servoNumTB.Text);
            byte position = Convert.ToByte(servoPosTB.Text);

            ServoCommand comm = new ServoCommand()
            {
                ServoNum = servoNum,
                Position = position
            };
            commDispatch.Dispatch(comm);
        }
    }

    public class FormCommand : Command
    {
        private string parameters;

        public FormCommand(string parameters, byte opCode) :base(opCode) { this.parameters = parameters; }
        public override byte[] ProvideParametersForDispatch()
        {
            return this.parameters.Select((char character) => (byte)character).ToArray();
        }
    }
}
