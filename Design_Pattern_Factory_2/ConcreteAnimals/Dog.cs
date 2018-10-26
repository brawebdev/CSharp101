using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern_Factory_2.ConcreteAnimals
{
    class Dog : IAnimal
    {
        public bool isAlive { get; set; }

        public void Attack()
        {
            Console.WriteLine("Dog bites you right on the genitals");
        }

        public void Move()
        {
            Console.WriteLine("Dog walks around like it owns the place.");
        }

        public void RunAway()
        {
            Console.WriteLine("Dog runs away with its tail tucked between it's legs.");
        }
    }
}
