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
            Action result = () => new Triangle(2,1,1);

            Assert.Throws<ArgumentException>(result);
        }

        [Fact]
        public void AreaCircleWithRadius5Equals78()
        {
            Circle circle = new(5);

            double result = circle.Area();

            Assert.Equal(78.5, result, 0.1);
        }
    }
}