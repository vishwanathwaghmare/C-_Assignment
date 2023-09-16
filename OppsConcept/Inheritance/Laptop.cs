using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppsConcept.Inheritance
{
    public class Laptop
    {
        private int noOfUSBPort;
        private int processorSpeed;

        public int GetNoOfUSBPort()
        {
            return noOfUSBPort;
        }
        public void SetNoOfUSBPort(int value)
        {
            noOfUSBPort = value;
        }

        public int GetProcessorSpeed()
        {
            return processorSpeed;
        }
        public void SetProcessorSpeed(int value)
        {
            processorSpeed = value;
        }
    }





    class GetSetLaptop
    {
        static void Main(string[] args)
        {
            Laptop laptop = new Laptop();
            laptop.SetNoOfUSBPort(6);
            laptop.SetProcessorSpeed(5000);
        }
    }
}
