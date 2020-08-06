using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using WindowsInput;

namespace ArduinoWokring
{
    class Program
    {
        static void Main(string[] args)
        {
            SerialPort serialPort = new SerialPort("COM6", 9600);

            const int lookSpeed = 30;

            serialPort.Open();
            serialPort.ReadTimeout = 1;
            //inputSimulator = new InputSimulator();

            InputSimulator inputSimulator = new InputSimulator();

            while(true)
            {
                //int pressed = int.Parse(serialPort.ReadLine());

                //serialPort.DtrEnable = true;
                //serialPort.RtsEnable = true;

                //int bytes = serialPort.BytesToRead;
                //byte[] buffer = new byte[bytes];
                //serialPort.Read(buffer, 0, bytes);

                //Console.WriteLine(buffer[0]);

                //Console.WriteLine(serialPort.ReadExisting());



                //string pressed = serialPort.ReadExisting();

                //if(pressed.Length < 5)
                //{
                //Console.WriteLine(pressed);
                //}
                try
                {
                    int pressed = serialPort.ReadByte();

                    if (pressed == 1)
                    {
                        //inputSimulator.Mouse.LeftButtonClick();
                        inputSimulator.Mouse.MoveMouseBy(0, -lookSpeed);
                    }
                    if (pressed == 2)
                    {
                        inputSimulator.Mouse.MoveMouseBy(0, lookSpeed);
                    }
                    if (pressed == 3)
                    {
                        inputSimulator.Mouse.MoveMouseBy(-lookSpeed, 0);
                    }
                    if (pressed == 4)
                    {
                        inputSimulator.Mouse.MoveMouseBy(lookSpeed, 0);
                    }
                    if (pressed == 5)
                    {
                        inputSimulator.Mouse.LeftButtonClick();
                    }
                }
                catch
                {

                }
            }

        }
    }
}
