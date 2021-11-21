namespace VisitorPattern.Shapes
{
    public class Rectangle : Shape
    {
        public int Width { get; set; }

        public int Height { get; set; }

        public override void Accept(IShapeVisitor shapeVisitor)
        {
            shapeVisitor.VisitRectangle(this);
        }
    }
}