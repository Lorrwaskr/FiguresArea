using FiguresArea.Figures;

namespace FiguresArea.Tests;

public class CircleTests
{
    [Test]
    public void CorrectRadius_ReturnCorrectArea()
    {
        var circle = new Circle(5);

        var area = circle.GetArea();

        Assert.That(area, Is.EqualTo(Math.PI * 25).Within(1e-10));
    }

    [Test]
    public void LargeRadius_ReturnCorrectArea()
    {
        var circle = new Circle(2000000);

        var area = circle.GetArea();

        Assert.That(area, Is.EqualTo(Math.PI * 2000000 * 2000000).Within(1e-10));
    }

    [Test]
    public void ZeroRadius_ThrowArgumentException()
    {
        Assert.Throws<ArgumentException>(() =>
        {
            var circle = new Circle(0);
        });
    }

    [Test]
    public void NegativeRadius_ThrowArgumentException()
    {
        Assert.Throws<ArgumentException>(() =>
        {
            var circle = new Circle(-100);
        });
    }
}
