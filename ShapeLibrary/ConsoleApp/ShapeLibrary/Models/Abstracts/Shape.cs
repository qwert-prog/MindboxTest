namespace ShapeLibrary.Models.Abstracts
{
    /// <summary>
    /// Базовый класс фигуры.
    /// </summary>
    public abstract class Shape
    {
        /// <summary>
        /// Вычисляет площадь фигуры.
        /// </summary>
        /// <returns>Площадь фигуры.</returns>
        public abstract double Area();
    }
}
