using System;
using System.Collections.Generic;
using System.Text;

namespace L8_3.Shapes
{
    abstract class Shape
    {
        public abstract double CalculatePerimeter();
        public abstract double CalculateArea();
        public virtual string Draw()
        {
            return "Drawing";
        }
    }
}
