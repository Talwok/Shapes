namespace Shapes.Test;

public class TriangleTests
{
    [Fact]
    public void TriangleAreaTest()
    {
        var triangle = new Triangle(3, 4, 5);
        double expected = 6;
        Assert.Equal(expected, triangle.CalculateArea(), 5);
    }

    [Fact]
    public void RightAngledTriangleTest()
    {
        var triangle = new Triangle(3, 4, 5);
        Assert.True(triangle.IsRightAngled());
    }

    [Fact]
    public void NonRightAngledTriangleTest()
    {
        var triangle = new Triangle(3, 4, 6);
        Assert.False(triangle.IsRightAngled());
    }
}