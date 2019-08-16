using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MindBox.SquareCalucaltor.Shapes;
using System.Linq;

namespace Tests
{
    [TestClass]
    public class Tests
    {
        [TestMethod]
        public void TestCircleValidate()
        {
            new Circle() { Radius = 123 }.GetSquare();
        }

        [TestMethod]
        public void TestTrigonValidate()
        {
            var defect = 0.00;
            //defect = 0.01;
            new Trigon(1, 1, Math.Sqrt(2)+defect).GetSquare();
        }

        [TestMethod]
        public void TestCircleSquare()
        {
            var defect = 0.00;
            //defect = 0.01;
            var c = new Circle() { Radius =2 };
            var x = c.GetSquare();
            var y = Math.PI * Math.Pow(2, 2) + defect;
            Assert.AreEqual(x, y);
        }

        [TestMethod]
        public void TestTrigonSquare()
        {
            var defect = 0.00;
            //defect = 0.01;
            var c = new Trigon(3, 4, 5);
            var x = Math.Round(c.GetSquare(), 3);
            var y = 6 + defect;
            Assert.AreEqual(x, y);
        }

        [TestMethod]
        public void TestTrigonNormal()
        {
            var defect = 0.00;
            //defect = 0.01; //Uncomment Me!
            var c = new Trigon(3, 4, 5 + defect);
            var yes = c.Sides.Exists(
                a => a.L2 ==
                    a.Neighbors.Sum(b => b.L2));             
            Assert.AreEqual(true, yes);
        }
    }
}
