using System;

namespace InheritanceAndInterfaces.Shapes
{
    public class Rectangle : Shape
    {
        private readonly double sideA;
        private readonly double sideB;

        public Rectangle(double sideA, double sideB)
        {
            this.sideA = sideA;
            this.sideB = sideB;
        }

        public override double GetArea()
        {
            double square = sideA * sideB;
            return square;
        }

        public override string GetName()
        {
            return "Rectangle";
        }
    }
}
