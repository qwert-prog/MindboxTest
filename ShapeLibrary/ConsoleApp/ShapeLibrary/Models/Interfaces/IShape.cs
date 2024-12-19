namespace ShapeLibrary.Models.Interfaces;

/// <summary>
/// Базовый класс фигуры.
/// </summary>
public interface IShape
{
    /// <summary>
    /// Вычисляет площадь фигуры.
    /// </summary>
    /// <returns>Площадь фигуры.</returns>
    public double Area();
}