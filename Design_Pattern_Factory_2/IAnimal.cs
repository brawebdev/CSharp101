using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern_Factory_2
{
    interface IAnimal
    {
        bool isAlive { get; set; }

        void Move();
        void Attack();
        void RunAway();
    }
}
