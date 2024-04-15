using ShapeLibrary.Models.Abstracts;

namespace ShapeLibrary.Models
{
    public sealed class Triangle : Shape
    {
        /// <summary>
        /// Первая сторона треугольника.
        /// </summary>
        public double A { get; }

        /// <summary>
        /// Вторая сторона треугольника.
        /// </summary>
        public double B { get; }

        /// <summary>
        /// Третья сторона треугольника.
        /// </summary>
        public double C { get; }

        public Triangle(double a, double b, double c)
        {
            if ((a is 0 or < 0) || (b is 0 or < 0) || (c is 0 or < 0))
            {
                throw new ArgumentException("Одна или более сторон <= 0. Данные некорректные.");
            }

            if (a + b > c && a + c > b && b + c > a)
            {
                A = a;
                B = b;
                C = c;
            }
            else
            {
                throw new ArgumentException("Треугольник с такими сторонами не может существовать.");
            }
        }

        public override double Area()
        {
            double area = 0;

            if (IsRight())
            {
                double[] sides = [A, B, C];
                area = 1;

                int longestSideIndex = Array.IndexOf(sides, sides.Max());
                for (int i = 0; i < sides.Length; i++)
                {
                    if (i != longestSideIndex)
                    {
                        area *= sides[i];
                    }
                }

                area /= 2;
            }
            else
            {
                double halfPerimeter = (A + B + C) / 2;

                area = Math.Sqrt(halfPerimeter * (halfPerimeter - A) * (halfPerimeter - B) * (halfPerimeter - C));
            }

            return area;
        }

        private bool IsRight()
        {
            double[] sides = [A, B, C];

            int longestSideIndex = Array.IndexOf(sides, sides.Max());

            double longSidePow2 = 0;
            double smallSidesPow2 = 0;

            for (int i = 0; i < sides.Length; i++)
            {
                if (i != longestSideIndex)
                {
                    smallSidesPow2 += Math.Pow(sides[i], 2);
                }
                else
                {
                    longSidePow2 = Math.Pow(sides[i], 2);
                }
            }

            return longSidePow2 == smallSidesPow2;
        }
    }
}