using FiguresArea.Figures;
using FiguresArea.Figures.Interfaces;

namespace FiguresArea.Tests;

public class InterfaceTests
{
    [Test]
    public void CorrectTriangle_ReturnCorrectArea()
    {
        var triangle = new Triangle(89, 45, 55);

        var area = CalculateArea(triangle);

        Assert.That(area, Is.EqualTo(1008.0878867936).Within(1e-10));
    }

    [Test]
    public void CorrectCircle_ReturnCorrectArea()
    {
        var circle = new Circle(5);

        var area = CalculateArea(circle);

        Assert.That(area, Is.EqualTo(Math.PI * 25).Within(1e-10));
    }

    private static double CalculateArea(IFigure figure)
    {
        return figure.GetArea();
    }
}