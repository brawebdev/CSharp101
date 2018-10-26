using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern_Factory_1
{
    abstract class VehicleFactory
    {
        public abstract IVehicle GetVehicle(string userInput);
    }
}
