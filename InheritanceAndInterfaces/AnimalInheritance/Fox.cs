using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceAndInterfaces.AnimalInheritance
{
    public class Fox:Predator
    {
        public Fox(string name) : base(name)
        {
        }
        public override void Eat()
        {
            Console.WriteLine("Fox is");
            base.Eat();
        }

        public override void MakeSound()
        {
            Console.WriteLine("Vulp, vulp!");
        }
    }
}

