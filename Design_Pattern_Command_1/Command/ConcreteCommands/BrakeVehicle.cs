using Design_Pattern_Command_1.Receiver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern_Command_1.Command.ConcreteCommands
{
    class BrakeVehicle : ICommand
    {
        private IVehicle _vehicle;

        public BrakeVehicle(IVehicle vehicle)
        {
            _vehicle = vehicle;
        }

        public void Execute()
        {
            _vehicle.Brake();
        }
    }
}
