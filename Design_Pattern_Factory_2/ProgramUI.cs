using System;

namespace Design_Pattern_Factory_2
{
    internal class ProgramUI
    {
        IAnimal _animal;
        private AbstractAnimalFactory _animalFactory = new ConcreteAnimalFactory();

        internal void Run()
        {
            Console.WriteLine("What Type of animal do you want?:\n\n" + "1.Dog" + "\n2.Monkey" + "\n3.Ben");
            int userInput = int.Parse(Console.ReadLine());

            _animal = _animalFactory.GetAnimal(userInput);

            _animal.isAlive = true;
            _animal.Move();
            _animal.Attack();
            _animal.RunAway();

            Console.ReadLine();
        }
    }
}