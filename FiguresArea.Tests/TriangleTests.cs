using FiguresArea.Figures;

namespace FiguresArea.Tests;

public class TriangleTests
{
    [Test]
    public void CorrectSides_ReturnCorrectArea()
    {
        var triangle = new Triangle(89, 45, 55);

        var area = triangle.GetArea();

        Assert.That(area, Is.EqualTo(1008.0878867936).Within(1e-10));
    }

    [Test]
    public void HeronsTriangle_ReturnIntegerArea()
    {
        var triangle = new Triangle(5, 4, 3);

        var area = triangle.GetArea();

        Assert.That(area, Is.EqualTo(6).Within(1e-10));
    }

    [Test]
    public void RightTriangle_CorrectCheck()
    {
        var triangle = new Triangle(5, 4, 3);

        var isRight = triangle.IsRightTriangle();

        Assert.That(isRight, Is.EqualTo(true));
    }

    [Test]
    public void NotRightTriangle_CorrectCheck()
    {
        var triangle = new Triangle(5, 4, 4);

        var isRight = triangle.IsRightTriangle();

        Assert.That(isRight, Is.EqualTo(false));
    }

    [Test]
    public void NegativeSide_ThrowArgumentException()
    {
        Assert.Throws<ArgumentException>(() =>
        {
            var triangle = new Triangle(5, 4, -1);
        });
    }

    [Test]
    public void OneSideGreaterThanOthers_ThrowArgumentException()
    {
        Assert.Throws<ArgumentException>(() =>
        {
            var triangle = new Triangle(10, 7, 1);
        });
    }
}
