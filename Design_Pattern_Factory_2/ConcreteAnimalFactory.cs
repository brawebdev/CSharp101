using Design_Pattern_Factory_2.ConcreteAnimals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern_Factory_2
{
    class ConcreteAnimalFactory : AbstractAnimalFactory
    {
        public override IAnimal GetAnimal(int userInput)
        {
            switch (userInput)
            {
                case 1:
                    return new Dog();
                case 2:
                    return new Monkey();
                case 3:
                    return new Ben();
                default:
                    throw new Exception("Bad user input!");
            }
        }
    }
}
