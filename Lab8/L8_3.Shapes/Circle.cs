using System;
using System.Collections.Generic;
using System.Text;

namespace L8_3.Shapes
{
    class Circle : Shape
    {
        const double Pi = 3.14;
        public double Radius { get; private set; }
        public Circle(double radius)
        {
            Radius = radius;
        }
        public override double CalculateArea()
        {
            return Radius * Radius * Pi;
        }
        public override double CalculatePerimeter()
        {
             return Radius * Pi * 2;
        }
        public override string Draw()
        {
            return base.Draw() + "Circle";
        }
    }
}
