using System;

namespace InheritanceAndInterfaces.Shapes
{
    public class Square : Shape
    {
        private readonly double side;

        public Square(double side)
        {
            this.side = side;
        }

        public override string GetName()
        {
            return "Square";
        }

        public override double GetArea()
        {
            return side * side;
        }
    }
}
