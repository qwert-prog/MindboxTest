using ShapeLibrary.Models;

namespace ConsoleApp
{
    internal static class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new(2);
            Triangle triangle = new(3,4,5);

            Console.WriteLine($"Площадь круга равна {circle.Area()}");
            Console.WriteLine($"Площадь треугольника равна {triangle.Area()}");

            Console.ReadKey();
        }
    }
}