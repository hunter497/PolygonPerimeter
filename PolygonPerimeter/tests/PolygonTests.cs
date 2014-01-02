using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace PolygonPerimeter.tests
{
    [TestFixture]
    public sealed class PolygonPerimeterTests
    {
        [Test]
        public void Test()
        {
            var polygonPerimeter = new PolygonPerimeter();
            var answer = polygonPerimeter.Perimeter(5, 3.7);
            Assert.AreEqual(21.748, answer);
        }

        [Test]
        public void OneHundredSidedPolygon()
        {
            var polygonPerimeter = new PolygonPerimeter();
            var answer = polygonPerimeter.Perimeter(100, 1.0);
            Assert.AreEqual(6.282, answer);
        }
    }
}
