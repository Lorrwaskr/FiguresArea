using FiguresArea.Figures.Abstract;

namespace FiguresArea.Figures;

public class Triangle : IFigure
{
    public double SideA { get; }
    public double SideB { get; }
    public double SideC { get; }

    public Triangle(double sideA, double sideB, double sideC)
    {
        if (sideA <= 0 || sideB <= 0 || sideC <= 0)
            throw new ArgumentException("All sides must be greater than 0.");

        if (!IsValidTriangle(sideA, sideB, sideC))
            throw new ArgumentException("The sum of any two sides must be greater than the third side.");

        SideA = sideA;
        SideB = sideB;
        SideC = sideC;
    }

    private static bool IsValidTriangle(double sideA, double sideB, double sideC)
    {
        return sideA + sideB > sideC && sideA + sideC > sideB && sideB + sideC > sideA;
    }

    public double GetArea()
    {
        double halfPerimeter = (SideA + SideB + SideC) / 2;
        return Math.Sqrt(halfPerimeter * (halfPerimeter - SideA) * (halfPerimeter - SideB) * (halfPerimeter - SideC));
    }

    public bool IsRightTriangle()
    {
        var sides = new[] { SideA, SideB, SideC };
        Array.Sort(sides);

        return Math.Abs(Math.Pow(sides[2], 2) - (Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2))) < 1e-10;
    }
}
