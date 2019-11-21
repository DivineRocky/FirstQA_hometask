using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceAndInterfaces.AnimalInheritance
{
    public class Wolf : Predator
    {
        public Wolf(string name) : base(name)
        {
        }

        public override void Eat()
        {
            Console.WriteLine("Wolf is");
            base.Eat();
        }

        public override void MakeSound()
        {
            Console.WriteLine("WOOOOOOOOOOOOOOH!");
        }
    }
}
