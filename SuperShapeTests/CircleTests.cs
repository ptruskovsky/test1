using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SuperShape.Shapes;

namespace SuperShapeTests {
    public class CircleTests
    {
        [Theory]
        [InlineData(2)]
        public void ShouldHaveArea_12_57(int radius) {
            var circle = new Circle(radius);
            var area = circle.CalculateArea();

            Assert.Equal(12.57, area);
        }
    }
}
