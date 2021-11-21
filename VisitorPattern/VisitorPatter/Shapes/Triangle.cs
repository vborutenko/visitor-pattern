namespace VisitorPattern.Shapes
{
    public class Triangle : Shape
    {
        public int A { get; set; }
        public int B { get; set; }
        public int C { get; set; }
        public override void Accept(IShapeVisitor shapeVisitor)
        {
            shapeVisitor.VisitTriangle(this);
        }
    }
}