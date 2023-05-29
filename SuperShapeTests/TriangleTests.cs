using SuperShape.Shapes;

namespace SuperShapeTests {
    public class TriangleTests {
        [Theory]
        [InlineData(3,4,5)]
        public void IsRightTriangleShouldBeFalse(int sideA, int sideB, int sideC) {
            var tirangle = new Triangle(sideA, sideB, sideC);
            var isRightTriangle = tirangle.IsRightTriangle();

            Assert.True(isRightTriangle);
        }

        [Theory]
        [InlineData(10, 11, 12)]
        [InlineData(20, 22, 24)]
        [InlineData(23, 24, 25)]
        public void IsNotRightTriangleShouldBeFalse(int sideA, int sideB, int sideC) {
            var tirangle = new Triangle(sideA, sideB, sideC);
            var isRightTriangle = tirangle.IsRightTriangle();

            Assert.False(isRightTriangle);
        }

        [Theory]
        [InlineData(3, 4, 5)]
        public void ShouldHaveArea_6(int sideA, int sideB, int sideC) {
            var tirangle = new Triangle(sideA, sideB, sideC);
            var area = tirangle.CalculateArea();

            Assert.Equal(6.00, area);
        }

    }
}