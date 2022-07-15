using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Text;

namespace geometry
{
    class Triangle :BaseShape
    {
        private double min_side = 0, mid_side = 0, max_side = 0;

        public Triangle(double side1, double side2, double side3)
        {
            Debug.Assert(side1 >= 0);
            Debug.Assert(side2 >= 0);
            Debug.Assert(side3 >= 0);
            min_side = Math.Min(side1, Math.Min(side2, side3));
            max_side = Math.Max(side1, Math.Max(side2, side3));
            mid_side = side1 + side2 + side3 - min_side - max_side;
        }

        private bool CheckRight()
        {
            return (Math.Pow(min_side, 2) + Math.Pow(mid_side, 2) == Math.Pow(max_side, 2)); 
        }

        private bool CheckEquilateral()
        {
            return (min_side == max_side);
        }

        private double Perimeter ()
        {
            return min_side + mid_side + max_side;
        }

        public override double GetArea()
        {
            if (CheckRight())
            {
                return 0.5 * min_side * mid_side;
            }
            if (CheckEquilateral())
            {
                return 0.25 * Math.Pow(min_side, 2) * Math.Sqrt(3);
            }
            double half_perimeter = Perimeter() * 0.5;
            return Math.Sqrt(half_perimeter *
                            (half_perimeter - min_side) *
                            (half_perimeter - mid_side) *
                            (half_perimeter - max_side));
        }


    }
}
