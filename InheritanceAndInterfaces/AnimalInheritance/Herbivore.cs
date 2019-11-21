using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceAndInterfaces.AnimalInheritance
{
    public abstract class Herbivore : Animal
    {
        public Herbivore(string name) : base(name)
        {

        }

        public override void Eat()
        {
            Console.WriteLine("Eating grass!");
        }

    }
}
