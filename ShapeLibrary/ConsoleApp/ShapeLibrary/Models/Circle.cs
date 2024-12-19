using ShapeLibrary.Models.Interfaces;

namespace ShapeLibrary.Models;

/// <summary>
/// Круг.
/// </summary>
public class Circle: IShape
{
    /// <summary>
    /// Радиус круга.
    /// </summary>
    private double _radius;

    /// <summary>
    /// <inheritdoc cref="_radius"/>
    /// </summary>
    /// <exception cref="ArgumentException">Некорректный радиус.</exception>
    public double Radius
    {
        get => _radius;
        private set
        {
            if(value is 0 or < 0)
            {
                throw new ArgumentException("Радиус не может быть меньше или равен 0.");
            }

            if(_radius == value)
            {
                return;
            }

            _radius = value;
        }
    }

    /// <summary>
    /// Инициализирует круг.
    /// </summary>
    /// <param name="radius">Радиус круга.</param>
    public Circle(double radius) => Radius = radius;

    public double Area() => Math.PI * Math.Pow(Radius, 2);
}