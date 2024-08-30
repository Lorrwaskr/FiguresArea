using FiguresArea.Figures.Abstract;

namespace FiguresArea.Figures;

public class Circle : IFigure
{
    public double Radius { get; }

    public Circle(double radius)
    {
        if (radius <= 0)
            throw new ArgumentException("Radius must be greater than 0", nameof(radius));

        Radius = radius;
    }

    public double GetArea()
    {
        return Math.PI * Math.Pow(Radius, 2);
    }
}
