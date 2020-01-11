using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArmFrontEnd
{
    class CommandDispatcher
    {
        public SerialPort SerialPort { get; private set; }
        public SerialDataReceivedEventHandler DataReceived { get; set; }

        public CommandDispatcher(string portName = "COM4", int baudRate = 9600)
        {
            SerialPort = new SerialPort()
            {
                PortName = portName,
                BaudRate = baudRate,
                DtrEnable = true,
                RtsEnable = true
            };
            SerialPort.DataReceived += SerialPort_DataReceived;
            SerialPort.Open();
        }

        ~CommandDispatcher()
        {
            if(SerialPort.IsOpen) { SerialPort.Close(); }
        }

        public void Dispatch(Command comm)
        {
            byte opCode = comm.Operation;
            byte[] dataPackage = comm.ProvideParametersForDispatch();


            short dataLength = Convert.ToInt16(dataPackage.Length);

            int bufferSize = 3 + dataLength;
            byte[] buffer = new byte[bufferSize];
            int pos = 0;
            buffer[pos++] = opCode;
            buffer[pos++] = (byte)(dataLength >> 8); 
            buffer[pos++] = (byte)dataLength;
            Array.Copy(dataPackage, 0, buffer, pos, dataLength);

            SerialPort.Write(buffer, 0, bufferSize);
        }

        private void SerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            //Forward data onto any listeners
            DataReceived?.Invoke(sender, e);
        }
    }

    public abstract class Command
    {
        public byte Operation { get; private set; }

        public abstract byte[] ProvideParametersForDispatch();

        public Command(byte opCode)
        {
            Operation = opCode;
        }
    }
}
