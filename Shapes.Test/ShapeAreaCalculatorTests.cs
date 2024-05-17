namespace Shapes.Test;

public class ShapeAreaCalculatorTests
{
    [Fact]
    public void ShapeAreaCalculatorTest()
    {
        IShape circle = new Circle(5);
        IShape triangle = new Triangle(3, 4, 5);

        Assert.Equal(Math.PI * 25, ShapeAreaCalculator.CalculateArea(circle), 5);
        Assert.Equal(6, ShapeAreaCalculator.CalculateArea(triangle), 5);
    }
}