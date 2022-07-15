using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace geometry
{
    class AnyEquilateralShape : BaseShape
    {
        double _side = 0;
        uint _size = 0;

        AnyEquilateralShape(double side, uint size) 
        {
            Debug.Assert(side >= 0);
            _side = side;
            _size = size;
        }

        public override double GetArea()
        {
            return (_size * Math.Pow(_side, 2)) / (4 * Math.Tan(180 / _size));
        }
    }
}
