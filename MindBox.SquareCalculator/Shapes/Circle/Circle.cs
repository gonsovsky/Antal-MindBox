using System;

namespace MindBox.SquareCalucaltor.Shapes
{
    public class Circle : Shape
    {
        [Positive] public double Radius { get; set; }

        protected override double Square =>
            Math.PI * Math.Pow(Radius, 2);
    }
}
