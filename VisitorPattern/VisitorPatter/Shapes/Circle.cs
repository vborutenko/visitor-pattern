namespace VisitorPattern.Shapes
{
    public class Circle : Shape
    {
        public int Radius { get; set; }
        public override void Accept(IShapeVisitor shapeVisitor)
        {
            shapeVisitor.VisitCircle(this);
        }
    }
}