using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern_Command_1.Receiver
{
    class Motorcycle : IVehicle
    {
        public void Brake()
        {
            Console.WriteLine("Slowing down motorcycle");
        }

        public void SpeedUp()
        {
            Console.WriteLine("Speeding up motorcycle");
        }

        public void TurnOff()
        {
            Console.WriteLine("Turning off motorcycle");
        }

        public void TurnOn()
        {
            Console.WriteLine("Turning on motorcycle");
        }
    }
}
