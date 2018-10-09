using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Value_Types_Business_Problem
{
    class Program
    {
        enum VehicleType { Car = 1, Boat, Motorcycle, Plane }

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Komodo! What is your name?");
            var name = Console.ReadLine();

            Console.WriteLine($"Welcome {name}! What is your age?");
            var age = int.Parse(Console.ReadLine());

            Console.WriteLine("Which type of vehicle are you trying to insure?" +
                "\n1) Car" +
                "\n2) Boat" +
                "\n3) Motorcycle" +
                "\n4) Plane");
            var vehicleTypeNum = int.Parse(Console.ReadLine());

            VehicleType vehicleType = (VehicleType)vehicleTypeNum;

            var insuranceCost = 0m;
            switch (vehicleType)
            {
                case VehicleType.Car:
                    if (age < 27) insuranceCost = 150.00m;
                    else if (age < 65) insuranceCost = 50.00m;
                    else insuranceCost = 100.00m;
                    break;
                case VehicleType.Boat:
                    if (age < 27) insuranceCost = 200.00m;
                    else if (age < 65) insuranceCost = 100.00m;
                    else insuranceCost = 150.00m;
                    break;
                case VehicleType.Motorcycle:
                    if (age < 27) insuranceCost = 200.00m;
                    else if (age < 65) insuranceCost = 100.00m;
                    else insuranceCost = 250.00m;
                    break;
                case VehicleType.Plane:
                    if (age < 27) insuranceCost = 1000.00m;
                    else if (age < 65) insuranceCost = 500.00m;
                    else insuranceCost = 1000.00m;
                    break;
            }
            Console.WriteLine($"Your insurance rates will be ${insuranceCost}.");
            Console.ReadKey();
        }
    }
}
