using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern_Factory_2.ConcreteAnimals
{
    class Monkey : IAnimal
    {
        public bool isAlive { get; set; }

        public void Attack()
        {
            Console.WriteLine("Monkey throws its own poo!");
        }

        public void Move()
        {
            Console.WriteLine("Monkey walks on all fours");
        }

        public void RunAway()
        {
            Console.WriteLine("Monkey runs away while waving its arms back and forth like an idiot.");
        }
    }
}
