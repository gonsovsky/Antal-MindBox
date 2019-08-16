using System;
using System.Collections.Generic;

namespace MindBox.SquareCalucaltor.Shapes
{
    public class TrigonSide
    {
        private Trigon _trigon;

        public TrigonSide(Trigon trigon)
        {
            _trigon = trigon;
        }

        public int Index { get; set; }

        public double L { get; set; }

        /// <summary>
        /// Squared length
        /// </summary>
        public double L2 => Math.Pow(L, 2);

        public TrigonSide Prev => _trigon.Sides[next];
        public TrigonSide Next => _trigon.Sides[prev];

        public List<TrigonSide> Neighbors =>
            new List<TrigonSide> { Prev, Next };

        public string Letter =>
            ((Char)(65 + Index)).ToString();

        public string Side => Letter + Next.Letter;   

        private int next =>
                       Index == 2 ? 0 : Index + 1;

        private int prev =>
            Index == 0 ? 2 : Index - 1;
    }
}
