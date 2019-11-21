using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceAndInterfaces.AnimalInheritance
{
    public class Rabbit : Herbivore
    {
        public Rabbit(string name) : base(name)
        {
        }

        public override void Eat()
        {
            Console.WriteLine("Rabbit is");
            base.Eat();
        }

        public override void MakeSound()
        {
            Console.WriteLine("Hssss, Hssss!");
        }
    }
}
