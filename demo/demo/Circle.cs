using System;
using System.Collections.Generic;
using System.Text;

namespace demo
{
    public class Circle : Dimension
    {
        public Circle(double radius) : base(radius, radius)
        {
        }
        public override double Area()
        {
            return pi * x * y;
        }
        public override double AbstractArea() 
        {
            return pi * x * y;
        }
    }
}
