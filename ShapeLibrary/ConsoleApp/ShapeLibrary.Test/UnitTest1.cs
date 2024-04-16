namespace ShapeLibrary.Test
{
    public class UnitTest1
    {
        [Fact]
        public void InvalidCircle()
        {
            Action result = () => new Circle(-1);

            Assert.Throws<ArgumentException>(result);
        }

        [Fact]
        public void InvalidTriangle()
        {
            Action result = () => new Triangle(2, 1, 1);

            Assert.Throws<ArgumentException>(result);
        }

        [Fact]
        public void AreaCircleWithRadius5Equals78()
        {
            Circle circle = new(5);

            double result = circle.Area();

            Assert.Equal(78.5, result, 0.1);
        }

        [Fact]
        public void AreaCircleTwoSuccess()
        {
            Circle circle = new(13);

            double result = circle.Area();

            Assert.Equal(530.9291, result, 0.0001);
        }

        [Fact]
        public void AreaTriangleSuccess()
        {
            Triangle triangle = new(3, 4, 5);

            double result = triangle.Area();

            Assert.Equal(6, result, 0.00001);
        }

        [Fact]
        public void AreaTriangleTwoSuccess()
        {
            Triangle triangle = new(8, 10, 12);

            double result = triangle.Area();

            Assert.Equal(39.6862, result, 0.0001);
        }

        [Fact]
        public void IsRightTriangleTest()
        {
            Triangle triangle = new(3, 4, 5);

            bool result = triangle.IsRight();

            Assert.True(result);
        }

        [Fact]
        public void IsNotRightTriangleTest()
        {
            Triangle triangle = new(8, 10, 12);

            bool result = triangle.IsRight();

            Assert.False(result);
        }
    }
}