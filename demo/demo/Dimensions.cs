using System;
using System.Collections.Generic;
using System.Text;

namespace demo
{
    
        public abstract class Dimension 
        {
            public const double pi = Math.PI;
            protected double x, y;
            public Dimension(double x, double y)
            {
                this.x = x;
                this.y = y;
            }
            public virtual double Area()
            {
                return x * y;
            }
        public abstract double AbstractArea();
    }
    }

