using System;
using System.Collections.Generic;
using System.Text;

namespace demo
{
    public class Sphere:Dimension
    {
        public Sphere(double radius) : base(radius, radius)
        {
        }

        public override double AbstractArea()
        {
            return 4 * pi * x * y;
        }

   
    }
}
