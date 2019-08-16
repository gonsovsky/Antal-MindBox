using MindBox.SquareCalucaltor.Shapes;

namespace MindBox.SquareCalucaltor
{
    public class SquareCalculator
    {
        public double GetSquare(Shape shape)
        {
            return shape.GetSquare();
        }

        public double GetCircleSquare(double radius)
        {
            return new Circle() { Radius = radius }.GetSquare();
        }

        public double GetTrigonSquare(double a, double b, double c)
        {
            return new Trigon(a,b,c).GetSquare();
        }
    }
}
