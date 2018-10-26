using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern_Factory_1.ConcreteVehicles
{
    class Car : IVehicle
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public DoorNumber DoorNumber { get; set; }
        public bool HasGas { get; set; }

        public void Brake()
        {
            Console.WriteLine("Car is braking.");
        }

        public void FuelStatus()
        {
            if (HasGas)
                Console.WriteLine("Car has gas");
            else
                Console.WriteLine("Car does not have gas.");
        }

        public void Move()
        {
            Console.WriteLine("Car is moving");
        }

        public void Start()
        {
            Console.WriteLine("Car starts");
        }
    }
}
