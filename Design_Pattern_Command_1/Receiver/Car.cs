using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern_Command_1.Receiver
{
    public class Car : IVehicle
    {
        public void Brake()
        {
            Console.WriteLine("Slowing down the car.");
        }

        public void SpeedUp()
        {
            Console.WriteLine("Speeding up the car.");
        }

        public void TurnOff()
        {
            Console.WriteLine("Turning off the car.");
        }

        public void TurnOn()
        {
            Console.WriteLine("Turning on the car.");
        }
    }
}
