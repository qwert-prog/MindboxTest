using ShapeLibrary.Models.Abstracts;

namespace ShapeLibrary.Models
{
    public sealed class Circle : Shape
    {
        private double _radius;

        /// <summary>
        /// Радиус круга.
        /// </summary>
        public double Radius
        {
            get => _radius;
            private set
            {
                if (value is 0 or < 0)
                {
                    throw new ArgumentException("Радиус не может быть меньше или равен 0.");
                }

                if (_radius != value)
                {
                    _radius = value;
                }
            }
        }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public override double Area() => Math.PI * Math.Pow(Radius, 2);
    }
}