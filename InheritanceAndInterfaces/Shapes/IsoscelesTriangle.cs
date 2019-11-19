namespace InheritanceAndInterfaces.Shapes
{
    public sealed class IsoscelesTriangle : Triangle
    {
        public IsoscelesTriangle(double sideA, double sideB, double sideC) 
            : base(sideA, sideB, sideC)
        {
        }

        public override string GetName()
        {
            return "Isosceles triangle";
        }
    }
}
