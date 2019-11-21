using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceAndInterfaces.AnimalInheritance
{
    public class Deer:Herbivore
    {
        public Deer(string name) : base(name)
        {
        }

        public override void Eat()
        {
            Console.WriteLine("Deer is");
            base.Eat();
        }

        public override void MakeSound()
        {
            Console.WriteLine("Yeeeeeeee, Yeeeeeeeeee!");
        }
    }
}
