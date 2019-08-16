using System;
using System.Collections.Generic;
using System.Linq;

namespace MindBox.SquareCalucaltor.Shapes
{
    public class Trigon : Shape
    {
        public double[] P { get; }

        [Positive] public double A => P[0];

        [Positive] public double B => P[1];

        [Positive] public double C => P[2];

        [TrigonValidator]  public List<TrigonSide> Sides { get; }

        public Trigon(double a, double b, double c)
        {
            P = new double[] { a, b, c };
            Sides = new List<TrigonSide>() { };
            for (int i = 0; i <= P.Length - 1; i++)
            {
                var side = new TrigonSide(this)
                {
                    Index = i,
                    L = P[i]
                };
                Sides.Add(side);                
            }
        }

        protected override double Square
        {
            get
            {
                var semi_perimeter = P.Sum(a => a /2);
                var heron = P.Select(a=> semi_perimeter - a)
                    .Aggregate((x,y) => x*y);
                return Math.Sqrt(semi_perimeter * heron);
            }
        }
    }
}
