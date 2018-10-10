using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_General_Concepts
{
    class BarnOwl : IBird
    {
        public bool Create()
        {
            throw new NotImplementedException();
        }

        public void Eat()
        {
            Console.WriteLine("This chicadee is good");
        }

        public void FlapWings()
        {
            Console.WriteLine("No sound");
        }

        public void MakeSound()
        {
            Console.WriteLine("sssssssssssssssssss");
        }

        public void Move()
        {
            Console.WriteLine("dude that thing is creeping me out");
        }
    }
}
