using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Text;


namespace geometry
{
    class Circle : BaseShape
    {
        private double _radius = 0;


        public Circle(double radius)
        {
            Debug.Assert(radius >= 0);
            _radius = radius;
        }

        public override double GetArea()
        {
            return Math.PI * Math.Pow(_radius, 2);
        }
    }
}
