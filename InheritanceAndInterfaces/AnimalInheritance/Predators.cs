using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceAndInterfaces.AnimalInheritance
{
    public abstract class Predator : Animal
    {
        public Predator(string name): base(name)
        {
           
        }

        public override void Eat()
        {
            Console.WriteLine("Eating meat!");
        }

    }
}
