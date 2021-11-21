namespace VisitorPattern.Shapes
{
    public abstract class Shape
    {
        public abstract void Accept(IShapeVisitor shapeVisitor);
    }
}