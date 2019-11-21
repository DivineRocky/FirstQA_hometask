using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceAndInterfaces.AnimalInheritance
{
    public abstract class Animal
    {
        readonly string name;

        public Animal(string name)
        {
            this.name = name;
        }
        public abstract void MakeSound();

        public abstract void Eat();

        public void GetName()
        {
            Console.WriteLine(name);
        }

    }


}
