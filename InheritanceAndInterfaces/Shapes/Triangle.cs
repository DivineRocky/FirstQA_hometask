using System;

namespace InheritanceAndInterfaces.Shapes
{
    public class Triangle : Shape
    {
        private readonly double sideA;
        private readonly double sideB;
        private readonly double sideC;

        public Triangle(double sideA, double sideB, double sideC)
        {
            this.sideA = sideA;
            this.sideB = sideB;
            this.sideC = sideC;
        }

        public override double GetArea()
        {
            double s = (sideA + sideB + sideC) / 2;
            double square = Math.Sqrt(s * (s - sideA) * (s - sideB) * (s - sideC));
            return square;
        }       

        public override string GetName()
        {
            return "Triangle";
        }
    }
}
