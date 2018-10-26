using System;

namespace Design_Pattern_Factory_1
{
    internal class ProgramUI
    {
        private VehicleFactory _factory = new ConcreteVehicleFactory();
        private IVehicle _vehicle;

        internal void Run()
        {
            Console.WriteLine("What Type of vehicle do you want?:\n\n" + "1.Car");
            string userInput = Console.ReadLine();

            _vehicle = _factory.GetVehicle(userInput);

            _vehicle.Start();
            _vehicle.Move();
            _vehicle.Name = "Car";
            _vehicle.HasGas = true;


            Console.ReadLine();
        }
    }
}