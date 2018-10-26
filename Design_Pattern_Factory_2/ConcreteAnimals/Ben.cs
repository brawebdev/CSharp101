using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern_Factory_2.ConcreteAnimals
{
    class Ben : IAnimal
    {
        public bool isAlive { get; set; }

        public void Attack()
        {
            Console.WriteLine("Ben throws mad shade.");
        }

        public void Move()
        {
            Console.WriteLine("Ben loudly stumbles about.");
        }

        public void RunAway()
        {
            Console.WriteLine("Ben runs away awkwardly");
        }
    }
}
