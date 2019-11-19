namespace InheritanceAndInterfaces.Shapes
{
    public abstract class Shape: IShape
    {
        public virtual string GetName()
        {
            return "Shape";
        }

        public abstract double GetArea();

    }
}
