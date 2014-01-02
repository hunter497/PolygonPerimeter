using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolygonPerimeter
{
    class Program
    {
        static void Main(string[] args)
        {
            var polygonPerimeter = new PolygonPerimeter();
            Console.Out.WriteLine("Please enter the number of sides: ");
            var numOfSides = Convert.ToInt32(Console.ReadLine());
            Console.Out.WriteLine("Please enter the circumradius: ");
            var circumradius = Convert.ToDouble(Console.ReadLine());
            Console.Out.WriteLine("The perimeter of the polygon is: " + polygonPerimeter.Perimeter(numOfSides, circumradius));
            Console.In.ReadLine();
        }
    }
}
