namespace Shapes;

public class Circle(double radius) : IShape
{
    public double Radius { get; } = radius;

    public double CalculateArea()
    {
        return Math.PI * Math.Pow(Radius, 2);
    }
}
