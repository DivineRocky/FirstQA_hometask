using System;

namespace InheritanceAndInterfaces.Shapes
{
    public class Circle : Shape
    {
        private double r;

        public Circle(double r)
        {
            this.r = r;
        }

        public override string GetName()
        {
            return "Circle";
        }

        public override double GetArea()
        {
            double square = Math.PI * r * r;
            return square;
        }
    }
}
