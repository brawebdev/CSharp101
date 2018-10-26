using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern_Factory_2
{
    abstract class AbstractAnimalFactory
    {
        public abstract IAnimal GetAnimal(int userInput);
    }
}
