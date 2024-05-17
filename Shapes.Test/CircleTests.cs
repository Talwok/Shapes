namespace Shapes.Test;

public class CircleTests
{
    [Fact]
    public void CircleAreaTest()
    {
        var circle = new Circle(5);
        var expected = Math.PI * 25;
        Assert.Equal(expected, circle.CalculateArea(), 5);
    }
}
