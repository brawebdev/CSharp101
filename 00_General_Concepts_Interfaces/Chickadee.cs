using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_General_Concepts
{
                                              //T    //TT
    class Chickadee : IBird, ICrudRepository<string, Bird>
    {
                            //vvv-- Notice that T is type string here
        public bool Create(string foo)
        {
            throw new NotImplementedException();
        }

        public Bird GetAll()
        {
            throw new NotImplementedException();
        }

        public bool Delete()
        {
            throw new NotImplementedException();
        }

        public void Eat()
        {
            throw new NotImplementedException();
        }

        public void FlapWings()
        {
            throw new NotImplementedException();
        }

        public void MakeSound()
        {
            Console.WriteLine("Chica dee dee dee dee");
        }

        public void Move()
        {
            throw new NotImplementedException();
        }

        public void Read()
        {
            throw new NotImplementedException();
        }

        public bool Update()
        {
            throw new NotImplementedException();
        }




    }
}
