using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern_Factory_1
{
    public enum DoorNumber { One, Two, Four, Other}

    interface IVehicle
    {
        string Name { get; set; }
        string Color { get; set; }
        DoorNumber DoorNumber { get; set; }
        bool HasGas { get; set; }

        void Move();
        void Start();
        void Brake();
        void FuelStatus();
    }
}
