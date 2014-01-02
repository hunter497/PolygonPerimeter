using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolygonPerimeter
{
    class PolygonPerimeter
    {
        public double Perimeter(int numOfSides, double circumradius)
        {
            var perimeter = 0.0;
            var oneSide = 0.0;
            oneSide = circumradius*(2*Math.Sin(Math.PI/numOfSides));
            perimeter = oneSide*numOfSides;
            return Math.Truncate(perimeter * 1000) / 1000;
        }
    }
}
