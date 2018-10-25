using Design_Pattern_Command_1.Command;
using Design_Pattern_Command_1.Command.ConcreteCommands;
using Design_Pattern_Command_1.Invoker;
using Design_Pattern_Command_1.Receiver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern_Command_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Receiver
            IVehicle car = new Car();
            IVehicle motorcycle = new Motorcycle();

            //Concrete commands
            ICommand turnOnCarCommand = new TurnOnVehicle(car);
            ICommand turnOffCarCommand = new TurnOffVehicle(car);
            ICommand speedUpCarCommand = new SpeedUpVehicle(car);
            ICommand brakeCarCommand = new BrakeVehicle(car);

            ICommand turnOnMotorcycleCommand = new TurnOnVehicle(motorcycle);
            ICommand turnOffMotorcycleCommand = new TurnOffVehicle(motorcycle);
            ICommand speedUpMotorcycleCommand = new SpeedUpVehicle(motorcycle);
            ICommand brakeMotorcycleCommand = new BrakeVehicle(motorcycle);

            //Invoker
            VehicleInvoker carInvoker = new VehicleInvoker(turnOnCarCommand, turnOffCarCommand, speedUpCarCommand, brakeCarCommand);
            VehicleInvoker motorcycleInvoker = new VehicleInvoker(turnOnMotorcycleCommand, turnOffMotorcycleCommand,
                speedUpMotorcycleCommand, brakeMotorcycleCommand);

            carInvoker.TurnOn();
            carInvoker.SpeedUp();
            carInvoker.Brake();
            carInvoker.TurnOff();

            motorcycleInvoker.TurnOn();
            motorcycleInvoker.SpeedUp();
            motorcycleInvoker.Brake();
            motorcycleInvoker.TurnOff();
            Console.ReadLine();
        }
    }
}
