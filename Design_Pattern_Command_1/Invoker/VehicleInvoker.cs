using Design_Pattern_Command_1.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern_Command_1.Invoker
{
    public class VehicleInvoker
    {
        private ICommand _turnOn, _turnOff, _speedUp, _brake;

        public VehicleInvoker(ICommand turnOn, ICommand turnOff, ICommand speedUp, ICommand brake)
        {
            _turnOn = turnOn;
            _turnOff = turnOff;
            _speedUp = speedUp;
            _brake = brake;
        }

        public void TurnOn()
        {
            _turnOn.Execute();
        }

        public void TurnOff()
        {
            _turnOff.Execute();
        }

        public void SpeedUp()
        {
            _speedUp.Execute();
        }

        public void Brake()
        {
            _brake.Execute();
        }

    }
}
